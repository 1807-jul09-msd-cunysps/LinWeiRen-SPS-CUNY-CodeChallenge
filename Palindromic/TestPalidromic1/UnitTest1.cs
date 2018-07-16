using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromic;

namespace TestPalidromic1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string test1 = "Anutforajar of tuna";
            string test2 = "Borrow or rob";
            string test3 = "343";
            bool actual1;
            bool expected1 = true;
            bool actual2;
            bool expected2 = true;
            bool actual3;
            bool expected3 = true;

            //Act
            actual1 = PalidromicClass.Check(test1);
            actual2 = PalidromicClass.Check(test2);
            actual3 = PalidromicClass.Check(test3);

            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
    }
}
