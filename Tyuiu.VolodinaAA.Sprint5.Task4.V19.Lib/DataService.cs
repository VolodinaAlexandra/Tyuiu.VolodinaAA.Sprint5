using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VolodinaAA.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    { 
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX);
            double res = Math.Round(Math.Pow(x / Math.Cos(x), 2), 3);
            return res;
        }
    }
}
