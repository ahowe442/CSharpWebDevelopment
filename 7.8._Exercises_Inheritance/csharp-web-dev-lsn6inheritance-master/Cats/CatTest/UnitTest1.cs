using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cats;


namespace CatTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InheritsBaseInFirstConstructor()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat", 7);
            Assert.AreEqual(7, keyboardCat.Weight, .001);
        }
    }
}
