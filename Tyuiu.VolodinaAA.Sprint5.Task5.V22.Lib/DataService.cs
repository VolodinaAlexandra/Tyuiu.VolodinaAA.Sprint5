using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VolodinaAA.Sprint5.Task5.V22.Lib
{
    public class DataService : ISprint5Task5V22
    {
        public double LoadFromDataFile(string path)
        {
            double res = double.MaxValue;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (double.TryParse(line, out double value))
                    {
                        if (value % 1 == 0 && value % 4 == 0 && value < res)
                        {
                            res = value;
                        }
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
