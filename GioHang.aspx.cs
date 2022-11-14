using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLySanPhamTHTKW
{
    public partial class GioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCART();
            }

        }
        public void LoadCART()
        {
            App_code.CART cart = (App_code.CART)Session["CART"];
            this.grvCART.DataSource = cart.LISTCART.Values.ToList();
            this.grvCART.DataBind();
            this.grvCART.FooterRow.Cells[0].Text = "Tổng tiền ";
            this.grvCART.FooterRow.Cells[4].Text = cart.TotalBill().ToString();
        }

        protected void btnDELETE_Click(object sender, EventArgs e)
        {
            App_code.CART cart = (App_code.CART)Session["CART"];
            foreach (GridViewRow row in grvCART.Rows)
            {
                CheckBox ckb = (CheckBox)row.FindControl("ckbREMOVEITEM");
                if (ckb.Checked)
                {
                    String masanpham = row.Cells[0].Text;
                    cart.RemoveCart(masanpham);
                }
            }
            Session["CART"] = cart;
            LoadCART();
        }

        
    }
}