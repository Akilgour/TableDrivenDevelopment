using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TableDrivenDevelopment.Models;

namespace TableDrivenDevelopment.Helpers
{
    public static class AnimalSearchTableDriven
    {

        public static List<Animal> Search(List<Animal> animalList, Animal seachAnimal)
        {
            //var list = new List<Animal>();
            //list.Add(animalList.First());
            //return list;

            //IEnumerable<Animal> users = from user in animalList
            //                          where
            //                               (seachAnimal.ScreenName != null && user.ScreenName.Contains(search))
            //                               || (user.FirstName != null && user.FirstName.Contains(search))
            //                               || (user.LastName != null && user.LastName.Contains(search))
            //                          select user;

            //var users = from user in animalList
            //            where
            //                 (user.Name != null && user.Name.Contains(seachAnimal.Name))
            //            select user; 

            //var users = from user in animalList
            //            where
            //                 ((user.Name != null && seachAnimal.Name != null && seachAnimal.Name != string.Empty ) && user.Name.Contains(seachAnimal.Name))
            //            select user;        

            var resultsAnimal = from animal in animalList
                                where ((animal.Name != null      && seachAnimal.Name != null          && seachAnimal.Name != string.Empty) && animal.Name.Contains(seachAnimal.Name))
                                || ((animal.NumberOfLegs != null && seachAnimal.NumberOfLegs != null) && animal.NumberOfLegs == seachAnimal.NumberOfLegs)
                                || ((animal.NumberOfWings != null && seachAnimal.NumberOfWings != null) && animal.NumberOfWings == seachAnimal.NumberOfWings)

                                || (seachAnimal.CanFly != null && animal.CanFly != null && animal.CanFly == seachAnimal.CanFly)
                                || (seachAnimal.CanGoUnderwater != null && animal.CanGoUnderwater != null && animal.CanGoUnderwater == seachAnimal.CanGoUnderwater)

                                select animal;
            return resultsAnimal.ToList();

             

        }

    }
}