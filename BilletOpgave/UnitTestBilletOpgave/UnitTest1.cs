using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
using System;

namespace UnitTestBilletOpgave
{
    [TestClass]
    public class UnitTest1
    {
        BilClass Bil = new BilClass();
        MCClass MC = new MCClass();

        [TestMethod]
        public void TestMethodBilPris()
        {
            //Arrange
            var result = Bil.Pris();

            //Act

            //Assert
            Assert.AreEqual(240, result);
        }

        [TestMethod]
        public void TestMethodBilKøretøj()
        {
            //Arrange
            var result = Bil.Køretøj();

            //Act

            //Assert
            Assert.AreEqual("Bil", result);
        }
        [TestMethod]
        public void TestMethodMCPris()
        {
            //Arrange
            var result = MC.Pris();
            //Act
            //Assert
            Assert.AreEqual(125, result);
        }
        [TestMethod]
        public void TestMethodMCKøretøj()
        {
            //Arrange
            var result = MC.Køretøj();
            //Act
            //Assert
            Assert.AreEqual("MC", result);
        }
    }
}
