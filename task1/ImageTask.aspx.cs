using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task1
{
    public partial class ImageTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Server.MapPath("Images")))
            {
                Directory.CreateDirectory(Server.MapPath("Images"));
            }
            string imageurl = (Server.MapPath("Images") + "\\" + fileupload.FileName);
            fileupload.SaveAs(imageurl);
        }
    }
}