﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class InoxPan : AbstractPan
    {
        public override string ToString()
        {
            return Material + Name;
        }
        public override double increaseTemperatrue(double firstTemperature, double secondTemperature)
        {
            double mass = double.Parse(Mass.Substring(0, Mass.IndexOf("Kg")));

            return Math.Abs(mass * 1000 * 0.5 * ((firstTemperature + 273.15) - (secondTemperature + 273.15)) / 1500.0);
        }

        public override double decreaseTemperatrue(double firstTemperature, double secondTemperature)
        {
            double mass = double.Parse(Mass.Substring(0, Mass.IndexOf("Kg")));
            return Math.Abs((mass * 1000 * 0.5 * ((firstTemperature + 273.15) - (secondTemperature + 273.15)))/ 10 * 0.1);
        }
    }
}
