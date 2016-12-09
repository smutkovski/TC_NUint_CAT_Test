using System;
using NUnit.Framework;

namespace TC_NUint_CAT_Test
{
    
    public class TestBase: IDisposable
    {

        [SetUp]
        public void SetUp() { }

        [TearDown]
        public void CleanUp()
        {

            Dispose();
        }

        public void Dispose()
        {
           
        }

       
    }
}
