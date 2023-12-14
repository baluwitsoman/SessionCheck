using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationTest
{
    public partial class PageA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod(enableSession: true)]
        public static string Web1()
        {
            var watch = Stopwatch.StartNew();

            Debug.Print("start 1");
            HttpContext.Current.Session["web1"] = "running";
            System.Threading.Thread.Sleep(4000);
          //  HttpContext.Current.Session["web1"] = "done";
            Debug.Print("start 1 done");
            
            return "Web 1:" + watch.Elapsed.TotalSeconds + "min:ss: " + DateTime.Now.ToString("mm:ss");
        }
        [WebMethod(enableSession: true)]
        public static string Web2()
        {
            var watch = Stopwatch.StartNew();
            Debug.Print("start 2");
            HttpContext.Current.Session["web2"] = "running";
            System.Threading.Thread.Sleep(4000);
            //HttpContext.Current.Session["web2"] = "done";
            Debug.Print("start 2 done");
            return "Web 2: " + watch.Elapsed.TotalSeconds + "min:ss: " + DateTime.Now.ToString("mm:ss");
           
        }


    }
}