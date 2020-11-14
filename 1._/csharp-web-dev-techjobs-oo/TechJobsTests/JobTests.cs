using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            var job1 = new Job();
            var job2 = new Job();

            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestSettingJobID2()
        {
            var job1 = new Job();
            var job2 = new Job();

            Assert.AreEqual(job1.Id, job2.Id -1, .001);
        }


        //TODO: Test the Full Constructor
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            var job3 = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence" );
        }

    }
}
