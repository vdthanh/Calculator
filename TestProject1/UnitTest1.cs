using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void SetUp()
        {
        }

        [TestMethod]
        public void TestPower_SoNguyen_MuSoThuc()
        {
            double expected = Math.Pow(2, 4.5);
            double actual = Calculation.Power(2, (float)4.5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPower_SoThuc_MuSoThuc()
        {
            double expected = Math.Pow(2.1, 4.5);
            double actual = Calculation.Power(2, (float)4.5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPower_SoNguyen_Mu0()
        {
            double expected = Math.Pow(2, 0);
            double actual = Calculation.Power(2, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPower_SoThuc_Mu0()
        {
            double expected = Math.Pow(2.1, 0);
            double actual = Calculation.Power((float)2.1, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPower_SoNguyen_MuLonHon0()
        {
            double expected = Math.Pow(2, 5);
            double actual = Calculation.Power(2, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPower_SoThuc_MuLonHon0()
        {
            double expected = Math.Pow(5.1, 5);
            double actual = Calculation.Power((float)5.1, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPower_SoNguyen_MuNhoHon0()
        {
            double expected = Math.Pow(5, -5);
            double actual = Calculation.Power(5, -5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPower_SoThuc_MuNhoHon0()
        {
            double expected = Math.Pow(5.1, -5);
            double actual = Calculation.Power((float)5.1, -5);
            Assert.AreEqual(expected, actual);
        }

        
    }
}
