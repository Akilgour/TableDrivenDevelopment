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
            var list = new List<Animal>();
            list.Add(animalList.First());
            return list;
        }

    }
}