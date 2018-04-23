using System;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Init(object sender, EventArgs e) {
        xds.Session = XpoHelper.GetNewSession();
    }
}