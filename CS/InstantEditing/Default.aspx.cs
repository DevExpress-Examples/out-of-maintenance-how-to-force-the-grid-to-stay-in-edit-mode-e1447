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

namespace InstantEditing {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            XpoDataSource1.Session = XpoHelper.GetNewSession();
            if(!IsPostBack && !IsCallback) {
                ASPxGridView1.DataBind();  // prepares the grid for the first StartEdit method call from FocusedRowChanged
            }
        }
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ASPxGridView1_FocusedRowChanged(object sender, EventArgs e) {
            ASPxGridView1.UpdateEdit();
            ASPxGridView1.StartEdit(ASPxGridView1.FocusedRowIndex);
            ASPxGridView1.DataBind();
        }
    }
}