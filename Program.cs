using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Toyota toyota = new Toyota();
            Console.WriteLine("All vehicles have "+ toyota.wheels + " Wheels");
            Console.WriteLine("Toyota vehicle has "+ toyota.spareWheel + "  Spare wheels");

            Console.Read();
        }
    }
}
