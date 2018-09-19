using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendor_Plugin_Interface;

public class SomeClass : IVendorPluginInterface
{
    public string VendorName()
    {
        return "Addition";
    }

    public string Description(int a, int b)
    {
        return "Add(" + a + ", " + b + ") = ";
    }

    public int MathAction(int a, int b)
    {
        return a + b;
    }
}

