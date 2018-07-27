using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsComponentNameSpace;

namespace MathsTestProject
{
    [TestClass]
    public class UnitTest1
    {
       public UnitTest1()
        {

        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }

            set
            {
                testContextInstance = value;
            }
        }




        [TestMethod]
        public void TestAdd()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            MathsComponent obj = new MathsComponent();
            int result2 = obj.Subtract(100, 90);
            Assert.AreEqual(10, result2);
        }
    }
}
