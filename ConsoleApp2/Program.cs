using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessBytes();
            Console.ReadLine();
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static void ProcessBytes()
        {
            byte bl = 100;
            byte b2 = 250;


            unchecked
            {
                byte sum = (byte)(bl + b2);
                Console.WriteLine($"sum = {sum}");
            }
        }
    }
}








