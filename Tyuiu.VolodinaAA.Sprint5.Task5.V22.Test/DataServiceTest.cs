using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VolodinaAA.Sprint5.Task5.V22.Lib;

namespace Tyuiu.VolodinaAA.Sprint5.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFileValid()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait1 = true;
            Assert.AreEqual(wait1, fileExists);
        }
        [TestMethod]
        public void CheckResultsValid()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";
            double res = ds.LoadFromDataFile(path);
            double wait2 = 16;
            Assert.AreEqual(wait2, res);
        }
    }
}
