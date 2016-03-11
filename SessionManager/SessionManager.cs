using System.Web.UI;

namespace WebApplication1
{
    public class SessionManager
    {
        private Page _page;

        public SessionManager(Page page)
        {
            _page = page;
        }

        public void SetSession(string key , object value)
        {
            _page.Session[key] = value;
        }

        public object GetSession(string key)
        {
            return _page.Session[key];
        }

    }
}