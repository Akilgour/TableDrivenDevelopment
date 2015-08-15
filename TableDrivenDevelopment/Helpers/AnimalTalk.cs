using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TableDrivenDevelopment.Models;

namespace TableDrivenDevelopment.Helpers
{
    public static class AnimalTalk
    {
        public static string Talk(Animal Animal)
        {
            return Animal.Voice;
        }
    }
}