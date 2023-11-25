using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VolodinaAA.Sprint5.Task6.V28.Lib
{
    public class DataService : ISprint5Task6V28
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string pattern = @"\b\d{4}\b";
                    MatchCollection matches = Regex.Matches(line, pattern);
                    count = matches.Count;
                }
            }
            return count;

        }
    }
}
