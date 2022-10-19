using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //右側對齊星形三角形
            for(int i = 1; i <= 5; i++)
            {
                int space = 5 - i;
                int star = i;
                string row = new string(' ', space)+new string('*', star);
                Console.WriteLine(row);
            }


        }
    }
}
