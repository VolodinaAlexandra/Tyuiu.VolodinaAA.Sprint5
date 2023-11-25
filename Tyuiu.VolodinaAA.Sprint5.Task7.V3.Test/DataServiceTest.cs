﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VolodinaAA.Sprint5.Task7.V3.Lib;

namespace Tyuiu.VolodinaAA.Sprint5.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadDataAndSaveValid()
        {
            string path = @"C:\DataSprint5\OutPutDataFileTask7V3.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait1 = true;
            Assert.AreEqual(wait1, fileExists);
        }
    }
}
