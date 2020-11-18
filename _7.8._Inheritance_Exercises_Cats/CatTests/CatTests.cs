using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _7._8._Inheritance_Exercises_Cats;

//TODO: Learn how to configure this without thet test template

namespace _7._8._Inheritance_Exercises_Cats.CatTests
{
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        public void InheritsBaseInFirstConstructor()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat", 7);
            Assert.AreEqual(7, keyboardCat.Weight, .001);
        }
    }
}
