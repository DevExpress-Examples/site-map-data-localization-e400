using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Threading;
using System.Globalization;

public partial class _Default : System.Web.UI.Page {
    protected override void InitializeCulture() {
        if (Request.Form["DropDownList1"] != null) {
            String selectedLanguage = Request.Form["DropDownList1"];
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(selectedLanguage);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(selectedLanguage);
        }
        base.InitializeCulture();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e) {
        ASPxMenu1.DataBind();
    }
}
