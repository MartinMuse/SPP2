using System;
using Generator;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalifornicationGenerator
{
    public class CalifornicationGenerator : IBaseGenerator
    {
        private const string PATH_TO_TEXT = "Californication.txt";
        private string[] lines;
        private Random random;
        public Type GeneratingType
        {
            get { return typeof(string); }
        }
        public CalifornicationGenerator()
        {
            string tempText = File.ReadAllText(PATH_TO_TEXT);
            lines = tempText.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            random = new Random();
        }


        public object Generate()
        {
            return lines[random.Next(lines.Length)];
        }
    }
}

