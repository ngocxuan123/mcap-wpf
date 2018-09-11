using System.Globalization;
using System.Windows.Controls;

namespace Mcap.Validation
{
    internal class RequiredValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var str = value as string;
            if (string.IsNullOrEmpty(str))
            {
                return new ValidationResult(false, "Không được để trống");
            }
            return new ValidationResult(true, null);
        }
    }
}
