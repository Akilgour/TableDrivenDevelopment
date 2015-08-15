﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableDrivenDevelopment.Models;

namespace TableDrivenDevelopment.Tests.Factories
{
    public class FourAnimalFactory
    {
        public List<Animal>  GetAnimals()
        {
            List<Animal>  animalList = new List<Animal>();

            animalList.Add(new Animal()
            {
                Id = Guid.NewGuid(),
                NumberOfLegs = 4,
                CanFly = false,
                CanGoUnderwater = false,
                Name = "Cat",
                Voice = "Meow",
                NumberOfWings = 0
            });

            animalList.Add(new Animal()
            {
                Id = Guid.NewGuid(),
                NumberOfLegs = 4,
                CanFly = false,
                CanGoUnderwater = false,
                Name = "Dog",
                Voice = "Woof",
                NumberOfWings = 0
            });

            animalList.Add(new Animal()
            {
                Id = Guid.NewGuid(),
                NumberOfLegs = 2,
                CanFly = false,
                CanGoUnderwater = false,
                Name = "Canary",
                Voice = "Chirp",
                NumberOfWings = 2
            });

            animalList.Add(new Animal()
            {
                Id = Guid.NewGuid(),
                NumberOfLegs = 2,
                CanFly = false,
                CanGoUnderwater = false,
                Name = "Octopus",
                Voice = "Bubble",
                NumberOfWings = 2
            });

            return animalList;
        }

    }
}
