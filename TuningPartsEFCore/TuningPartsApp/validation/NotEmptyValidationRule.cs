using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TuningPartsApp.views
{
    public class NotEmptyValidationRule : ValidationRule
    {

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value.GetType() != typeof(string))
            {
                return new ValidationResult(false, $"{value} kann nicht überprüft werden");
            }
            if (string.IsNullOrWhiteSpace((string)value))
            {
                return new ValidationResult(false, "Wert muss aus Buchstaben und/oder Zahlen bestehen!");
            }

            return ValidationResult.ValidResult;
        }
    }
}
