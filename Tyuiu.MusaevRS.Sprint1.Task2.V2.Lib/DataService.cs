﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MusaevRS.Sprint1.Task2.V2.Lib
{
    public class DataService : ISprint1Task2V3
    {
        public int ConvertHourToMin(int value)
        {
            return value * 60;
        }
    }
}
