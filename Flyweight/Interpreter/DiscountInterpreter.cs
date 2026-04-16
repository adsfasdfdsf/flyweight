using System.Text.RegularExpressions;

namespace ECommerceMVP;

public class DiscountInterpreter
{
    public decimal Interpret(string discountCode, OrderContext context)
        {
            discountCode = discountCode.ToUpper();
            bool isPercentage = discountCode.StartsWith("DISCOUNT");
            bool isFixed = discountCode.StartsWith("SAVE");
            
            if (!isPercentage && !isFixed)
                return 0;
            decimal discountValue = GetDiscountValue(discountCode);
            string condition = GetCondition(discountCode);
            if (CheckCondition(condition, context))
            {
                if (isPercentage)
                    return context.Amount * discountValue / 100;
                else
                    return Math.Min(discountValue, context.Amount);
            }
            
            return 0;
        }
        
        private decimal GetDiscountValue(string code)
        {
            var match = Regex.Match(code, @"\d+(\.\d+)?");
            if (match.Success)
                return decimal.Parse(match.Value);
            return 0;
        }
        
        private string GetCondition(string code)
        {
            int onIndex = code.IndexOf("ON");
            if (onIndex == -1)
                return "ALL";
            
            string afterOn = code.Substring(onIndex + 2).Trim();
            
            if (afterOn.StartsWith("ALL"))
                return "ALL";
            
            return afterOn;
        }
        
        private bool CheckCondition(string condition, OrderContext context)
        {
            if (condition == "ALL")
                return true;
            if (condition.Contains("AND"))
            {
                string[] parts = condition.Split(new[] { "AND" }, StringSplitOptions.None);
                foreach (var part in parts)
                {
                    if (!CheckSimpleCondition(part.Trim(), context))
                        return false;
                }
                return true;
            }
            if (condition.Contains("OR"))
            {
                string[] parts = condition.Split(new[] { "OR" }, StringSplitOptions.None);
                foreach (var part in parts)
                {
                    if (CheckSimpleCondition(part.Trim(), context))
                        return true;
                }
                return false;
            }
            return CheckSimpleCondition(condition, context);
        }
        
        private bool CheckSimpleCondition(string condition, OrderContext context)
        {
            condition = condition.Trim('(', ')');
            
            if (condition.StartsWith("CATEGORY:"))
            {
                string category = condition.Substring(9);
                return string.Equals(context.Category, category, StringComparison.OrdinalIgnoreCase);
            }
            
            if (condition.StartsWith("BRAND:"))
            {
                string brand = condition.Substring(6);
                return string.Equals(context.Brand, brand, StringComparison.OrdinalIgnoreCase);
            }
            
            return false;
        }
}