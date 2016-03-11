using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class About : Page
    {
        private readonly SessionManager _sessionManager;

        public About()
        {
            _sessionManager = new SessionManager(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           var aaa = _sessionManager.GetSession("aaa");
        }
    }
}