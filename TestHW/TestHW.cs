using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestHW
{
    [TestFixture]
    class Test_Helloworld
    {
        [Test]
        public void Test_Bad_Output()
        {
            Program p = new Program();  

            string result = p.OutputHW(cw);

            Assert.AreEqual(result, "HelloWorld!");
        }

    }
}   
