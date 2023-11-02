using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASM2.NewFolder;
using ASM2.NewFolder1;

namespace ASM2.Factory
{
    public interface IKitchenFactory
    {
        AbstractPan CreatePan();
        AbstractPot CreatePot();
    }
}
  