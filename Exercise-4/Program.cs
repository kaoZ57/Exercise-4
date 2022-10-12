using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(4, 5, 10);
            Console.WriteLine("box area is : ", box.area());
        }
    }
}
