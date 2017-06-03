using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 24;
            int pencilsBought = 7;
            int cashBack = 10;
            int pencilsCost = (money - cashBack) / pencilsBought;

            Console.WriteLine(pencilsCost);
            

        }

        

    }
}
