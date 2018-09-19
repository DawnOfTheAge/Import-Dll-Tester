using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendor_Plugin_Interface;

public class YetAnotherDll : IVendorPluginInterface
{
    public string VendorName()
    {
        return "Multiplication";
    }

    public string Description(int a, int b)
    {
        return "Multiply(" + a + ", " + b + ") = ";
    }

    public int MathAction(int a, int b)
    {
        return a * b;
    }
}

