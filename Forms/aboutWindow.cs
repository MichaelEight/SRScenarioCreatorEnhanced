using System;
using System.Reflection;
using System.Windows.Forms;

namespace SRScenarioCreatorEnhanced.Forms
{
    partial class aboutWindow : Form
    {
        public aboutWindow()
        {
            InitializeComponent();
            //Text = String.Format("About {0}", AssemblyTitle);
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = String.Format("Version:\nEditor: {0}\nAssembly: {1}",
                                Configuration.editorVersion, Configuration.assemblyVersion);
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
    }
}
