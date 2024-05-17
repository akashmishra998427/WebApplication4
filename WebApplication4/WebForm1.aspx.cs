using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string userid, password, address;
        userid = Textid.Text;
        password = Textpass.Text;
        address = Textadd.Text;
        lblresult.Text = userid + "<br/>" + password + "<br/>" + address;
    }
}