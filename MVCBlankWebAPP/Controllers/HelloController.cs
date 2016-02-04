using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlankWebAPP.Controllers
{
    public class HelloController : Controller
    {
        //public void Execute(System.Web.Routing.RequestContext requestContext)
        //{
        //    requestContext.HttpContext.Response.Write("Hello World");
                     
        //}

        public string SayHello(int? sample)
        {
            return "Hello world! V2" + sample.ToString();
            //this is master branch controller
        }
    }
}