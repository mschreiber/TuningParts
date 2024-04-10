using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TuningPartsApp.views
{
    public class NotNullValidationRule : ValidationRule
    {

        public string Message { get; set; } = "Bitte einen Wert auswählen";

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return new ValidationResult(false, Message);
            }
            return ValidationResult.ValidResult;
        }
    }
}
