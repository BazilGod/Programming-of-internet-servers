using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Client
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client client;
        public Form1()
        {
            InitializeComponent();
            this.client = new ServiceReference1.Service1Client();
            this.client.Open();
            string sss = this.client.GetData(777);
            ServiceReference1.CompositeType ct = new ServiceReference1.CompositeType();
            ct.BoolValue = true;
            ct.StringValue = "stringss";
            ServiceReference1.CompositeType rc = this.client.GetDataUsingDataContract(ct);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try { 
            this.client = new ServiceReference1.Service1Client();
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Convert.ToString(this.client.Sum(x, y));
        }
            catch { MessageBox.Show(". "); }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.client = new ServiceReference1.Service1Client();
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(this.client.Min(x, y));
            }
            catch { MessageBox.Show(". "); }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.client = new ServiceReference1.Service1Client();
            textBox3.Text = this.client.Concat(textBox1.Text, textBox2.Text);
        }
    }
}
