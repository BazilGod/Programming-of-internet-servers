using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Host
{
    public partial class Form1 : Form
    {
        ServiceHost sh;
        public Form1()
        {
            InitializeComponent();
            this.sh = new ServiceHost(typeof(WcfServiceLibraryX.Service1));
            sh.Open();
        }
    }
}
