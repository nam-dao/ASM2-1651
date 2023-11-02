using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2.NewFolder1
{
    public abstract class AbstractPot
    {
        private string name;
        private string material;
        private string size;
        private string mass;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public string Mass
        {
            get { return mass; }
            set { mass = value; }
        }
        public abstract double increaseTemperatrue(double firstTemperature, double secondTemperature);

        public abstract double decreaseTemperatrue(double firstTemperature, double secondTemperature);

        public abstract double boilingMeat(double meatMass, double fitSize);
    }
}
