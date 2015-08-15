using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableDrivenDevelopment.Models;

namespace TableDrivenDevelopment.Tests.Factories
{
    public static class DogFactory
    {
        public static Animal GetDog()
        {
            return new Animal()
            {
                Id = Guid.NewGuid(),
                NumberOfLegs = 4,
                CanFly = false,
                CanGoUnderwater = false,
                Name = "Dog",
                Voice = "Woof",
                NumberOfWings = 0
            };
        }
    }
}

