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
            var cat = CatFactory.GetCat();

            //Act 
            var voice = AnimalTalk.Talk(cat);

            //Assert
            Assert.AreEqual(voice, "meow");
        }

    }
}
