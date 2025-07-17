using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogGameProje.Entity;

namespace BlogGameProje
{
    public partial class Default : System.Web.UI.Page
    {
        BlogOyunEntities1 db = new BlogOyunEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var bloglar = db.TBLBLOG.ToList();
                Repeater1.DataSource = bloglar;
                Repeater1.DataBind();
            }
        }
    }
}