using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:55689/Lab02/get.IBS?name=bazil&age=20");
            webRequest.Method = "GET";
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            StreamReader reader = new StreamReader(webResponse.GetResponseStream());
            Response.Write(reader.ReadToEnd());
        }

        protected  void PostButton_Click(object sender, EventArgs e)
        {
           
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:55689/Lab02/test.IBS");
            request.Method = "POST";
            string postData = "name=Bazil&age=20";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream postDataStream = request.GetRequestStream();
            postDataStream.Write(byteArray, 0, byteArray.Length);
            postDataStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Response.Write(reader.ReadToEnd());
        }

        protected void PutButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:55689/Lab02/put.IBS");
            request.Method = "PUT";

            string postData = "name=Bazil&age=20";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream postDataStream = request.GetRequestStream();
            postDataStream.Write(byteArray, 0, byteArray.Length);
            postDataStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Response.Write(reader.ReadToEnd());

        }

        protected void ErrorButton_Click(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:55689/Lab02/test.err?n=maks&s=men");
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                Response.Write(reader.ReadToEnd());
            }
            catch (WebException error)
            {
                Response.Write(error.Status);
                Response.Write("<br/>" + error.Message);
                Response.Write("<br/>" + error.TargetSite);
                Response.Write("<br/>" + error.Source);
            }

        }
    }
}