using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TableDrivenDevelopment.Tests.Factories;
using TableDrivenDevelopment.Helpers;
using TableDrivenDevelopment.Models;
using System.Collections.Generic;

namespace TableDrivenDevelopment.Tests.Helpers
{
    [TestClass]
    public class AnimalSearchTableDrivenTest
    {
        [TestMethod]
        public void GetCatCount()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();

            var searchAnimal = CatFactory.GetCat();

            //Act 
            var resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals.Count, 1);
        }

        [TestMethod]
        public void GetCatByName()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();
            var searchAnimal = new Animal()
            {
                Name = "Cat"
            };

            //Act 
            List<Animal> resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals[0].Name, "Cat");
        }

        [TestMethod]
        public void GetCountNoneWhereNameNull()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();
            var searchAnimal = new Animal()
            {
                Name = null
            };

            //Act 
            List<Animal> resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals.Count, 0);
        }

        [TestMethod]
        public void GetCountNoneWhereNameByStringEmpty()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();
            var searchAnimal = new Animal()
            {
                Name = String.Empty
            };

            //Act 
            List<Animal> resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals.Count, 0);
        }
    }
}
