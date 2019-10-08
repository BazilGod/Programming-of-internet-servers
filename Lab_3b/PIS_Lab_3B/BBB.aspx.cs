using System;
using System.Web.UI.WebControls;

namespace PIS_Lab_3B
{
    public partial class BBB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox5.Text = DateTime.Now.ToShortDateString();
        }

        protected void OnServerValidate(object source, ServerValidateEventArgs args)
        {
            var pass = TextBox8.Text;
            if (pass.Length < 7)
            {
                args.IsValid = false;
                return;
            }

            for (var i = 0; i < pass.Length; i++)
            {
                for (var j = i + 1; j < pass.Length; j++)
                {
                    if (pass[i] == pass[j])
                    {
                        args.IsValid = false;
                        return;
                    }
                }
            }

            args.IsValid = true;
        }
    }
}