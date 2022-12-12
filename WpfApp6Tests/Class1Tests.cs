using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void Check_Count3_ReturnsTrue()
        {
            // Arrange
            int num = 3;
            bool expected = false;

            // Act
            bool actual = Class1.StarsChecker(num);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}