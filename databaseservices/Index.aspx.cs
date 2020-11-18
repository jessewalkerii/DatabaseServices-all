using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.DirectoryServices.AccountManagement;

namespace databaseservices
{
    public partial class Index : System.Web.UI.Page
    {
        public String UserName;
        protected void Page_Load(object sender, EventArgs e)
        {
            // set up domain context
            PrincipalContext ctx = new PrincipalContext(ContextType.Domain);

            // find a user
            UserPrincipal user = UserPrincipal.FindByIdentity(ctx, HttpContext.Current.User.Identity.Name);
            UserName = user.GivenName + " " + user.Surname;

        }
    }
}