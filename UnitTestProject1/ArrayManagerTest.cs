using System;
using MainModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ArrayManagerTest
    {
        [TestMethod]
        public void FindMax_PositiveElements_Test()
        {
            //arrange
            int[] a = { 3, 4, 5, 6, 1 };
            int expected = 6;

            //act
            int actual = ArrayManager.FindMax(a);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FindMax_NegativeElements_Test()
        {
            //arrange
            int[] a = { -3, -4, -5, -6, -1 };
            int expected = -1;

            //act
            int actual = ArrayManager.FindMax(a);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void FindMax_NullArray_ExpectedException()
        {
            //arrange
            int[] a = null;


            //act
            int actual = ArrayManager.FindMax(a);

        }
        [TestMethod]
        public void FindMiddleValue_Test()
        {
            //arrange
            int[] a = { -3, 5, 2 };
            double expected = 1.33;
                        
            //act
            double actual = ArrayManager.GetMiddleValue(a);

            //assert
            Assert.AreEqual(expected, actual, 0.01);

        }
    }
}
