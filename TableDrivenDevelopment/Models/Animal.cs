using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TableDrivenDevelopment.Models
{
    public class Animal
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public int NumberOfWings { get; set; }
        public bool CanGoUnderwater { get; set; }
        public bool CanFly { get; set; }
        public string Voice { get; set; }
    }
}