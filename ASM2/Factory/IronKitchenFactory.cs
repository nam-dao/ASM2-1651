using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASM2.NewFolder;
using ASM2.NewFolder1;

namespace ASM2.Factory
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
