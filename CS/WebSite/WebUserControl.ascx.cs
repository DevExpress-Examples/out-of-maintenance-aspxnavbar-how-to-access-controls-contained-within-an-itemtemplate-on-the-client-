using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxNavBar;
using DevExpress.Web.ASPxEditors;

public partial class WebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e){

    }

    string fGroupIndex;

    public string GroupIndex {
        get { return fGroupIndex; }
        set { fGroupIndex = value; }
    }

    protected void Page_PreRender(object sender, EventArgs e) {
        ASPxButton1.ClientSideEvents.Click = "function(s, e){OnButtonClick(s, e, true, " + GroupIndex + ")}";
        ASPxButton2.ClientSideEvents.Click = "function(s, e){OnButtonClick(s, e, false, " + GroupIndex + ")}";
    }
}
