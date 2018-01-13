using Microsoft.VisualStudio.TestTools.UnitTesting;
using ADD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADD.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void AddTest()
        {
            Class1 mock = new Class1();
            var result = mock.Add();

            Assert.AreEqual(5, result);
        }
    }
}