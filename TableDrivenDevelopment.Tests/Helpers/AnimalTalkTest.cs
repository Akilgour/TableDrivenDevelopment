using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TableDrivenDevelopment.Tests.Factories;
using TableDrivenDevelopment.Helpers;

namespace TableDrivenDevelopment.Tests.Helpers
{
    [TestClass]
    public class AnimalTalkTest
    {
        [TestMethod]
        public void CatTalk()
        {
            //Arrange 
            var animal = CatFactory.GetCat();

            //Act 
            var voice = AnimalTalk.Talk(animal);

            //Assert
            Assert.AreEqual(voice, "Meow");
        }

        [TestMethod]
        public void DogTalk()
        {
            //Arrange 
            var animal = DogFactory.GetDog();

            //Act 
            var voice = AnimalTalk.Talk(animal);

            //Assert
            Assert.AreEqual(voice, "Woof");
        }
    }
}
