using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            float x, y, z;
            if (Single.TryParse(this.TextBox1.Text, out x)
                && Single.TryParse(this.TextBox2.Text, out y))
            {
                z = x + y;
                this.TextBox3.Text = z.ToString();
            }
            this.TextBox4.Text += "AA";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        float x, y, z;
        if (Single.TryParse(this.TextBox1.Text, out x)
            && Single.TryParse(this.TextBox2.Text, out y))
        {
            z = x + y;
            this.TextBox3.Text = z.ToString();
        }
        else
        {
            throw new ApplicationException("My Error");
        }
        this.TextBox4.Text += "AA";
        CheckBox1.Checked = true;
        RadioButton1.Checked = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        float x, y, z;
        if (Single.TryParse(this.TextBox5.Text, out x)
            && Single.TryParse(this.TextBox6.Text, out y))
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(15));
            z = x * y;
            this.TextBox7.Text = z.ToString();
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox4.Text += "AA";
        CheckBox1.Checked = true;
        RadioButton1.Checked = true;
    }


    protected void Timer1_Tick(object sender, EventArgs e)
    {
        float x, y, z;
        if (Single.TryParse(this.TextBox1.Text, out x)
            && Single.TryParse(this.TextBox2.Text, out y))
        {
            z = x + y;
            this.TextBox3.Text = z.ToString();
        }
    }

    protected void ScriptManager1_AsyncPostBackError(object sender, AsyncPostBackErrorEventArgs e)
    {
        this.ScriptManager1.AsyncPostBackErrorMessage = "My error text";
    }

    private int Counter1
    {
        get
        {
            object counter1 = ViewState["counter1"];
            if (counter1 == null)
                ViewState["counter1"] = 0;
            return (int)ViewState["counter1"];
        }

        set
        {
            ViewState["counter1"] = value;
        }
    }

    private int Counter2
    {
        get
        {
            object counter2 = ViewState["counter2"];
            if (counter2 == null)
                ViewState["counter2"] = 0;
            return (int)ViewState["counter2"];
        }

        set
        {
            ViewState["counter2"] = value;
        }
    }
    protected void Timer2_Tick(object sender, EventArgs e)
    {
        ++Counter1;
        Counter1Label.Text = Counter1.ToString();
    }

    protected void Timer3_Tick(object sender, EventArgs e)
    {
        ++Counter2;
        Counter2Label.Text = Counter2.ToString();
    }


    
}