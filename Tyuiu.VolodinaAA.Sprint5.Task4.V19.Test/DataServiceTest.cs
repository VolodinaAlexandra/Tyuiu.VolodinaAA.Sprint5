using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VolodinaAA.Sprint5.Task4.V19.Lib;

namespace Tyuiu.VolodinaAA.Sprint5.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFileValid()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V19.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait1 = true;
            Assert.AreEqual(wait1, fileExists);
        }
        [TestMethod] 
        public void CheckResultsValid()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V19.txt";
            double res = ds.LoadFromDataFile(path);
            double wait2 = 8.983;
            Assert.AreEqual(wait2, res);
        }

    }
}
