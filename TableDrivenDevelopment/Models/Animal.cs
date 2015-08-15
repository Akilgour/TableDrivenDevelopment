using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TableDrivenDevelopment.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        public int Wings { get; set; }
        public bool CanGoUnderwater { get; set; }
        public bool CanFly { get; set; }
        public string Voice { get; set; }
    }
}