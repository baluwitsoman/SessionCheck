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
    public partial class NoSessionPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod(enableSession: false)]
        public static string Nosession1()
        {
            var watch = Stopwatch.StartNew();

            System.Threading.Thread.Sleep(4000);

            return "Web 1:" + watch.Elapsed.TotalSeconds + "min:ss: " + DateTime.Now.ToString("mm:ss");
        }
        [WebMethod(enableSession: false)]
        public static string Nosession2()
        {
            var watch = Stopwatch.StartNew();
            System.Threading.Thread.Sleep(4000);
            return "Web 2: " + watch.Elapsed.TotalSeconds + "min:ss: " + DateTime.Now.ToString("mm:ss");

        }



    }
}