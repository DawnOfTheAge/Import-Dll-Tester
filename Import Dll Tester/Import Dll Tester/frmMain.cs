using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendor_Plugin_Interface;

namespace Import_Dll_Tester
{
    public partial class frmMain : Form
    {
        private List<IVendorPluginInterface> m_VendorPlugin;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string sVendorPluginsPath = @"C:\Projects\Import Dll Tester\Import Dll Tester\bin\Debug\Vendor Plugins";
            var vVendorPluginsFiles = Directory.GetFiles(sVendorPluginsPath, "*.dll");

            var vVendorPlugin = (from file in vVendorPluginsFiles
                                let asm = Assembly.LoadFile(file)
                                from type in asm.GetTypes()
                                where typeof(IVendorPluginInterface).IsAssignableFrom(type)
                                select (IVendorPluginInterface)Activator.CreateInstance(type)).ToArray();

            m_VendorPlugin = new List<IVendorPluginInterface>();
            foreach (var vSingleVendorPlugin in vVendorPlugin)
            {
                m_VendorPlugin.Add(vSingleVendorPlugin);
            }

            for (int i = 0; i < m_VendorPlugin.Count; i++)
            {
                cboVendorPlugin.Items.Insert(i, m_VendorPlugin[i].VendorName());
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboVendorPlugin.Text))
            {
                return;
            }

            int iIndex = (int)cboVendorPlugin.SelectedIndex;

            lblDescription.Text = m_VendorPlugin[iIndex].Description((int)nudA.Value, (int)nudB.Value);
            lblResult.Text = m_VendorPlugin[iIndex].MathAction((int)nudA.Value, (int)nudB.Value).ToString();
        }
    }
}
