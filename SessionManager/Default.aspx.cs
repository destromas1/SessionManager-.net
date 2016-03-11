using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        private readonly SessionManager _sessionManager;

        public _Default()
        {
            _sessionManager = new SessionManager(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _sessionManager.SetSession("aaa" , "AAA");
        }
    }


   
}