﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.外观模式
{
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("画一个长方形");
        }
    }
}
