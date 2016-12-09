using System;
using NUnit.Framework;
using TC_NUint_CAT_Test;

namespace TEST
{
    [TestFixture]
    public class Tests : TestBase
    {

        [SetUp]
        public void TestSetUp() { Console.WriteLine("TestSetup"); }


        [Test]
        [Category(TestCategory.Init)]
        public void SetupTest() {
            Console.Error.WriteLine("init");
        }
        [Test]
        [Category(TestCategory.A)]
        public void TestA()
        {
            Console.Error.WriteLine("A");
            Assert.AreEqual("A", "B", "TestA");
        }
        [Test]
        [Category(TestCategory.B)]
        public void TestB()
        {
            Console.Error.WriteLine("B");
            Assert.AreEqual("A", "B", "TestB");
        }
        [Test]
        [Category(TestCategory.A)]
        [Category(TestCategory.B)]
        public void TestAB()
        {
            Console.Error.WriteLine("AB");
            Assert.AreEqual("A", "B", "TestAB");
        }


        [TearDown]
        public void TestCleanUp() { }

    }
}
