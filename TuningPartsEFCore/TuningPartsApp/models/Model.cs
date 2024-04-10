using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuningPartsApp.models
{
    public class Model
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Production_Year { get; set; }
        public Brand? Brand { get; set; }
    }
}
