using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderDataService.Models
{
    public class Drink
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string glass_Type { get; set; }
        public bool alcohol { get; set; }
        public string directions { get; set; }
        public List<string> ingredients { get; set; }

    }
}
