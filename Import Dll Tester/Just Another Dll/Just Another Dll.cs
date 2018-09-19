using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendor_Plugin_Interface;

public class JustAnotherDll : IVendorPluginInterface
{
    public string VendorName()
    {
        return "Division";
    }

    public string Description(int a, int b)
    {
        return "Div(" + a + ", " + b + ") = ";
    }

    public int MathAction(int a, int b)
    {
        return a / b;
    }
}
