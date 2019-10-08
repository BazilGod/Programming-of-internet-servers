using System.Web.Services;

namespace Lab06_ASMX
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class TMAWebService : System.Web.Services.WebService
    {

        [WebMethod(Description = "x + y", EnableSession = true)]
       public int Add(int x, int y)
        {
            Application["history"] = (string)Application["history"] + "" + x + "+" + y + "=" + (x + y) + "; ";
            return x + y;
        }

        [WebMethod(Description = "x - y", EnableSession = true)]
        public int Sub(int x, int y)
        {
            Application["history"] = (string)Application["history"] + "" + x + "-" + y + "=" + (x - y) + "; ";
            return x - y;
        }

        [WebMethod(Description = "x * y", EnableSession = true)]
        public int Mul(int x, int y)
        {
            Application["history"] = (string)Application["history"] + "" + x + "*" + y + "=" + (x * y) + "; ";
            return x * y;
        }

        [WebMethod(Description = "Возвращает значение, хранящееся с помощью сессии", EnableSession = true)]
        public int GetSessionValue()
        {
            if (this.Session["temp"] == null)
            {
                this.Session["temp"] = 0;
            }
            return (int)this.Session["temp"];
        }

        [WebMethod(Description = "Устанавливает значение, хранящееся с помощью сессии", EnableSession = true)]
        public void SetSessionValue(int value)
        {
            this.Session["temp"] = value;
        }

        [WebMethod(Description = "Возвращает историю операций", EnableSession = true)]
        public string GetHistory()
        {
            return (string)Application["history"];
        }
    }
}
