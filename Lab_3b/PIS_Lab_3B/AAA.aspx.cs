using System;
using System.Web.UI.WebControls;

namespace PIS_Lab_3B
{
    public partial class AAA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            for (var i = 2; i < int.Parse(args.Value); i++)
            {
                if ((int.Parse(args.Value) % i == 0) && int.Parse(args.Value) != 1 )
                {
                    args.IsValid = false;
                    break;
                }
            }
        }
    }
}