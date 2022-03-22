using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DropDownList.Models
{
    public class State
    {
        public int id { get; set; }
        public string StateName { get; set; }
        public Country Country { get; set; }
    }
}
