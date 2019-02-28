using Facade;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using Facade;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Tests
{
    [TestClass]
    public class EmployeeViewModelTests
    {
        private EmployeeViewModel o;

        [TestInitialize]
        public void TestInitialize()
        {
            o = new EmployeeViewModel(null);
        }

        [TestMethod]
        public void SalaryColorIsRedByDefaultTest()
        {
            Assert.AreEqual("red",o.SalaryColor);
        }

        [TestMethod]
        public void SalaryColorIsRedIfSetColorArgumentIsNullTest()
        {
            o.setColor(null);
            Assert.AreEqual("red",o.SalaryColor);
        }

        [TestMethod]
        public void SalaryColorIsYellowForHighSalariesTest()
        {
            o.setColor(new EmployeeViewModel.Employee());
        }

    }
}