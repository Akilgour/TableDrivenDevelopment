using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TableDrivenDevelopment.Models;

namespace TableDrivenDevelopment.Helpers
{
    public static class AnimalSearchTableDriven
    {

        public static List<Animal> SearchOr(List<Animal> animalList, Animal seachAnimal)
        {
            var resultsAnimals = from animal in animalList
                                where ((animal.Name != null      && seachAnimal.Name != null          && seachAnimal.Name != string.Empty) && animal.Name.Contains(seachAnimal.Name))
                                || ((animal.NumberOfLegs != null && seachAnimal.NumberOfLegs != null) && animal.NumberOfLegs == seachAnimal.NumberOfLegs)
                                || ((animal.NumberOfWings != null && seachAnimal.NumberOfWings != null) && animal.NumberOfWings == seachAnimal.NumberOfWings)

                                || (seachAnimal.CanFly != null && animal.CanFly != null && animal.CanFly == seachAnimal.CanFly)
                                || (seachAnimal.CanGoUnderwater != null && animal.CanGoUnderwater != null && animal.CanGoUnderwater == seachAnimal.CanGoUnderwater)
                                || ((animal.Voice != null && seachAnimal.Voice != null && seachAnimal.Voice != string.Empty) && animal.Voice.Contains(seachAnimal.Voice))

                                select animal;
            return resultsAnimals.ToList();
        }

    }
}