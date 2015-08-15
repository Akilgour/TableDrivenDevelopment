using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableDrivenDevelopment.Models;

namespace TableDrivenDevelopment.Tests.Factories
{
    public static class CatFactory
    {
        public static Animal GetCat()
        {           
            return new Animal()
            {
                Id = Guid.NewGuid(),
                NumberOfLegs = 4,
                CanFly = false,
                CanGoUnderwater = false,
                Name = "Cat",
                Voice = "Meow",
                NumberOfWings = 0
            };
        }
    }
}

