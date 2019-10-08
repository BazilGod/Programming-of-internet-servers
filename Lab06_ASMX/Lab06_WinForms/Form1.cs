using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_WinForms
{
    public partial class Form1 : Form
    {
        TMAService.TMAWebServiceSoapClient client;

        public Form1()
        {
            InitializeComponent();
            client = new TMAService.TMAWebServiceSoapClient();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBoxX.Text.ToString());
            int y = Int32.Parse(textBoxY.Text.ToString());
            textBoxRes.Text = this.client.Add(x, y).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBoxX.Text.ToString());
            int y = Int32.Parse(textBoxY.Text.ToString());
            textBoxRes.Text = this.client.Sub(x, y).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBoxX.Text.ToString());
            int y = Int32.Parse(textBoxY.Text.ToString());
            textBoxRes.Text = this.client.Mul(x, y).ToString();
        }

        private void btnSessionSet_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(textBoxSessionValue.Text.ToString());
            this.client.SetSessionValue(value);
        }

        private void btnSessionGet_Click(object sender, EventArgs e)
        {
            textBoxSessionValue.Text = this.client.GetSessionValue().ToString();
        }

        private void btnUpdateHistory_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxHistory.Text = this.client.GetHistory();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
