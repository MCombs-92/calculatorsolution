using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace TestCalculator {
    [TestClass]
    public class TestCalculatorSuite {

        [TestMethod]
        public void TestAdd() {
            var test4 = "a,2";
            var actual = Program.Calculator(test4);
            Assert.AreEqual(-1, actual);

            var test5 = "2,3";
            actual = Program.Calculator(test5);
            Assert.AreEqual(4, actual);
        }
        [TestMethod]
        public void TestMore() {
            var test = "abc";
            var actual = Program.Calculator(test);
            Assert.AreEqual(-1, actual);
        }
    }
}
