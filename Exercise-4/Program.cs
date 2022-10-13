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
            Box box0 = new Box(width: 4, height: 5, length: 10);
            Console.WriteLine("box0 area is : {0}", box0.area());

            Box box1 = new Box(side: 5);
            Console.WriteLine("box1 area is : {0}", box1.area());

            Box box2 = new Box(oldBox: box0);
            Console.WriteLine("box2 area is : {0}", box2.area());

        }
    }
}
