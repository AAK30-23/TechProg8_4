using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace TechProg8_4
{
    public partial class Matrix
    {
        public static List<string[]> LoadMatrixFromFile(string filePath)
        {
            try
            {
                return File.ReadAllLines(filePath).Select(line => line.Split(new string[] { "||", "\t" }, StringSplitOptions.RemoveEmptyEntries)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка: " + ex.Message);
            }
        }

    }

    
}
