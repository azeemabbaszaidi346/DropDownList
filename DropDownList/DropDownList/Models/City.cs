using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DropDownList.Models
{
    public class City
    {
        public int id { get; set; }
        public string CityName { get; set; }
        public State State { get; set; }
    }
}
