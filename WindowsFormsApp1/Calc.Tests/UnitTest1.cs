using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calc.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_12and5is17()
        {
            int a = 12;
            int b = 5;
            int expected = 17;

            Calcul c = new Calcul();
            int actual = c.sum(a, b);

            Console.WriteLine("Проверка функции sum");

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void dif_12and5is7()
        {
            int a = 12;
            int b = 5;
            int expected = 7;

            Calcul c = new Calcul();
            int actual = c.dif(a, b);

            Console.WriteLine("Проверка функции dif");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void mult_3and5is15()
        {
            int a = 3;
            int b = 5;
            int expected = 15;

            Calcul c = new Calcul();
            int actual = c.mult(a, b);

            Console.WriteLine("Проверка функции mult");
            Assert.AreEqual(expected, actual);
        }
    }
}