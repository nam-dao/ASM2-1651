using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2.NewFolder
{
    public class IronPan : AbstractPan
    {
        public override double increaseTemperatrue(double firstTemperature, double secondTemperature)
        {
            double mass = double.Parse(Mass.Substring(0, Mass.IndexOf("Kg")));

            return Math.Abs(mass * 1000 * 0.449 * (firstTemperature + 273.15 - (secondTemperature + 273.15)) / 1500.0);
        }
        public override double decreaseTemperatrue(double firstTemperature, double secondTemperature)
        {
            double mass = double.Parse(Mass.Substring(0, Mass.IndexOf("Kg")));
            return Math.Abs(mass * 1000 * 0.449 * (firstTemperature + 273.15 - (secondTemperature + 273.15)) / 10 * 0.1);
        }
        public override double fryMeat(double meatMass, double fitSize)
        {
            double time = meatMass / fitSize * 300;
            return Math.Abs(time);
        }
    }
}
