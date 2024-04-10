using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TuningPartsApp.views
{
    public class YearRangeValidationRule : ValidationRule
    {

        public int Min { get; set; } = 0;
        public int Max { get; set; } = DateTime.Now.Year;

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            int year;

            if (value.GetType() != typeof(string))
            {
                return new ValidationResult(false, $"{value} kann nicht überprüft werden");
            }
            if (!Int32.TryParse((string)value, out year))
            {
                return new ValidationResult(false, $"{value} ist keine gültige Jahreszahl");
            }

            if (year < Min)
            {
                return new ValidationResult(false, $"Der Wert {value} darf nicht kleiner wie {Min} sein");
            }
            if (year > Max)
            {
                return new ValidationResult(false, $"Der Wert {value} darf nicht größer wie {new DateOnly().Year} sein");
            }
            return ValidationResult.ValidResult;
        }
    }
}
