﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern23.策略模式
{
    public class OperationSub : Strategy
    {
        public int doOperation(int num1, int num2)
        {
            return num2 - num1;
        }
    }
}
