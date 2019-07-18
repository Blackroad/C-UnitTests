using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainModule.Tests
{
    [TestClass()]
    public class MyArrayTests
    {
        MyArray arr;
        [TestInitialize]
        public void Setup()
        {
            int[] a = { 34, 6, 7 };
            arr = new MyArray(a);

        }
        [TestCleanup]
        public void Clean()
        {

        }

        [TestMethod()]
        public void FindMaxTest()
        {
            //arrange 
            int expected = 34;

            int actual = arr.FindMax();
            Assert.AreEqual(expected, actual);
        }
    }
}