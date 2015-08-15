using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TableDrivenDevelopment.Tests.Factories;
using TableDrivenDevelopment.Helpers;
using TableDrivenDevelopment.Models;

namespace TableDrivenDevelopment.Tests.Helpers
{
    [TestClass]
    public class AnimalSearchTableDrivenTest
    {
        [TestMethod]
        public void GetCatByNameCount()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();

            var searchAnimal = CatFactory.GetCat();

            //Act 
            var resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals.Count, 1);
        }


    }
}
