using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public interface IKitchenFactory
    {
        AbstractPan CreatePan();
        AbstractPot CreatePot();
    }
}
