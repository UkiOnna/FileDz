using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileDz
{
    class Program
    {
        static void Main(string[] args)
        {

            string way = (Directory.GetCurrentDirectory() + @"\input.txt");
            int numberA = 6;
            int numberB = 14;
            int sum=numberA+numberB;
          
            using (StreamWriter sw = new StreamWriter(way, true, System.Text.Encoding.Default))
            {
                sw.Write(numberA);
                sw.Write(" ");
                sw.Write(numberB);
            }

            way = (Directory.GetCurrentDirectory() + @"\output.txt");

            using (StreamWriter sw = new StreamWriter(way, true, System.Text.Encoding.Default))
            {
                sw.Write(sum);
            }

            using (StreamReader sr = new StreamReader(way))
            {
                int.TryParse(sr.ReadToEnd(), out sum);
            }

          
            Console.WriteLine("Сумма - {0}", sum);
            Console.ReadLine();
        }
    }
}
