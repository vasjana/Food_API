using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_API.Models
{
    public class FoodItem
    {
        public long Id { get; set; }
        public int Numbers {get; set; }
        public string Tags { get; set; }
        public bool LimitLicense { get; set; }
    }
}
