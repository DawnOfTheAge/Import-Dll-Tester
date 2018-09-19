using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendor_Plugin_Interface
{
    public interface IVendorPluginInterface
    {
        string VendorName();

        int MathAction(int a, int b);

        string Description(int a, int b);
    }
}
