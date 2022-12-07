using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web;

public partial class ASPxperience_NavBar_ClientAccessToControlsInTemplate : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e){

    }

    protected string GetItemClientName(NavBarItemTemplateContainer container){
        string name = "Item_" + container.Item.Group.Index.ToString() + "_" + container.Item.Index.ToString();
        return name;
    }

    protected string GetGroupIndex(NavBarItemTemplateContainer container) {
        string index = container.Item.Group.Index.ToString();
        return index;
    }
}

