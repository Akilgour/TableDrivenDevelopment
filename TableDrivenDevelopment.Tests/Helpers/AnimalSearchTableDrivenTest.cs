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
        public void GetDogCount()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();

            var searchAnimal = DogFactory.GetDog();

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
        public void GetDogByName()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();
            var searchAnimal = new Animal()
            {
                Name = "Dog"
            };

            //Act 
            List<Animal> resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals[0].Name, "Dog");
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

        [TestMethod]
        public void GetByNumberOfLegsOfLegsFour()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();
            var searchAnimal = new Animal()
            {
                NumberOfLegs = 4
            };

            //Act 
            List<Animal> resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals.Count, 2);
        }

        [TestMethod]
        public void GetByNumberOfLegsOfLegsFive()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();
            var searchAnimal = new Animal()
            {
                NumberOfLegs = 5
            };

            //Act 
            List<Animal> resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals.Count, 0);
        }
                
        [TestMethod]
        public void GetCanFlyIsTrue()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();
            var searchAnimal = new Animal()
            {
               CanFly = true
            };

            //Act 
            List<Animal> resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals.Count, 1);
        }

        [TestMethod]
        public void GetCanFlyIsFalse()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();
            var searchAnimal = new Animal()
            {
                CanFly = false
            };

            //Act 
            List<Animal> resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals.Count, 3);
        }
        

        [TestMethod]
        public void GetCanGoUnderwaterIsTrue()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();
            var searchAnimal = new Animal()
            {
                CanGoUnderwater = true
            };

            //Act 
            List<Animal> resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals.Count, 1);
        }

        [TestMethod]
        public void GetCanGoUnderwaterIsFalse()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();
            var searchAnimal = new Animal()
            {
                CanGoUnderwater = false
            };

            //Act 
            List<Animal> resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals.Count, 3);
        }

        [TestMethod]
        public void GetNumberOfWingsIsTwo()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();
            var searchAnimal = new Animal()
            {
                NumberOfWings = 2
            };

            //Act 
            List<Animal> resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals.Count, 1);
        }

        [TestMethod]
        public void GetNumberOfWingsIsZero()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();
            var searchAnimal = new Animal()
            {
                NumberOfWings = 0
            };

            //Act 
            List<Animal> resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals.Count, 3);
        }

        [TestMethod]
        public void GetVoiceMeow()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();
            var searchAnimal = new Animal()
            {
                Voice = "Meow"
            };

            //Act 
            List<Animal> resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals.Count, 1);
        }

        [TestMethod]
        public void GetVoiceWoof()
        {
            //Arrange 
            var animalList = FourAnimalFactory.GetAnimals();
            var searchAnimal = new Animal()
            {
                Voice = "Woof"
            };

            //Act 
            List<Animal> resultsAnimals = AnimalSearchTableDriven.Search(animalList, searchAnimal);

            //Assert
            Assert.AreEqual(resultsAnimals.Count, 1);
        }

    }
}
