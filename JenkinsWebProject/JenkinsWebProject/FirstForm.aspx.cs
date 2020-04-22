using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JenkinsWebProject
{
    public partial class FirstForm : System.Web.UI.Page
    {
        //ILog log = log4net.LogManager.GetLogger(typeof(FirstForm)); FileAppender
        ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello First Web Form!");
          //  log4net.Config.XmlConfigurator.Configure();
            
            
            log.Info("Test");
            log.Debug("Test");
            log.Error("Test");
        }
    }
}