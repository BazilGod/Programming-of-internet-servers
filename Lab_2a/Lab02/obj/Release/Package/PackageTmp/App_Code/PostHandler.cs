using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab02.App_Code
{
    public class PostHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            if (request.Form.Count == 2)
            {
                string param1 = request.Form[0];
                string param2 = request.Form[1];
                response.Write($"POST-Http-TMA: ParmA = {param1}, ParmB = {param2}");
            }

            else { response.Write("Post HttpHandler"); }

            //var value1 = context.Request.Params["age"];
            //var value2 = context.Request.Params["name"];
            //response.Write($"Post  ParmA = {value1}, ParmB = {value2}");
        }

        public bool IsReusable => false;
    }
}