using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KultyshevaEA.Sprint4.TaskReview.V28.Lib;

namespace Tyuiu.KultyshevaEA.Sprint4.TaskReview.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 5;
            int columns = 3;
            int[,] matrix = new int[rows, columns];
            string str = "623351179845632";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 4608;
            Assert.AreEqual(wait, res);
        }
    }
}
