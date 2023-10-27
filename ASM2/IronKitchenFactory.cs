using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{

    public class IronKitchenFactory : IKitchenFactory
    {    
        public AbstractPan CreatePan()
        {
            return new IronPan();
        }

        public AbstractPot CreatePot()
        {
            return new IronPot();
        }
    }

}
