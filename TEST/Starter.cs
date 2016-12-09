using System;
using NUnit.Framework;

namespace TC_NUint_CAT_Test.TEST
{
    [SetUpFixture]
    class Starter
    {
        [OneTimeSetUp]
        public void Run() { }
        [OneTimeTearDown]
        public void Stop() { }

    }
}
