﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4._1
{
    class Subtraction : Operator
    {
        public override int Count()
        {
            return Left.Count() - Right.Count();
        }
    }
}
