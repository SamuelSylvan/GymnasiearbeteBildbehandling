using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Median
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> tal = new List<double>();
            string[] rader = File.ReadAllLines(@"C:\Users\SamuelSyl\source\repos\GymnasiearbeteWindowsForms\GymnasiearbeteWindowsForms\Median.txt");
            for (int i = 0; i < rader.Length; i++)
            {
                string[] rad = rader[i].Split(',');
                rad[0]=rad[0].Replace('.', ',');
                for (int Ii = 0; Ii < int.Parse(rad[1]); Ii++)
                {
                    tal.Add(double.Parse(rad[0]));
                }
            }
            var sorted = tal.OrderBy(x => x).ToList();
            Console.WriteLine($"Median: {sorted[sorted.Count/2]}");
            Console.WriteLine(tal.Count()%2);
            Console.ReadLine();
        }
    }
}
