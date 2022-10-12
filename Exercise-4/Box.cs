﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Box
    {
        double width, height, length;
        public Box(double width, double height, double length)
        {
            this.width = width;
            this.height = height;
            this.length = length;
        }

        public double faceArea()
        {
            return width * height;
        }

        public double topArea()
        {
            return width * length;
        }

        public double sideArea()
        {
            return length * height;
        }

        public double area()
        {
            return 2 * faceArea() + 2 * topArea() + 2 * sideArea();
        }
    }
}
