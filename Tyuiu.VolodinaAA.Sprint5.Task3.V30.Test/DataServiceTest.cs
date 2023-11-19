using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VolodinaAA.Sprint5.Task3.V30.Lib;

namespace Tyuiu.VolodinaAA.Sprint5.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextDataValid()
        {
            string path = @"C:\Users\Александра\source\repos\Tyuiu.VolodinaAA.Sprint5\Tyuiu.VolodinaAA.Sprint5.Task3.V30\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
