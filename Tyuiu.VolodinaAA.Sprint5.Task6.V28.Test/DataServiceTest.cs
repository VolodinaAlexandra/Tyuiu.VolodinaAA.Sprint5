using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VolodinaAA.Sprint5.Task6.V28.Lib;

namespace Tyuiu.VolodinaAA.Sprint5.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFileValid()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V28.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait1 = true;
            Assert.AreEqual(wait1, fileExists);
        }
        [TestMethod]
        public void CheckResultsValid()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V28.txt";
            double res = ds.LoadFromDataFile(path);
            double wait2 = 3;
            Assert.AreEqual(wait2, res);
        }
    }
}
