using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class InoxKitchenFactory : IKitchenFactory
    {
        public AbstractPan CreatePan()
        {
            return new InoxPan();
        }

        public AbstractPot CreatePot()
        {
            return new InoxPot();
        }
    }
}
