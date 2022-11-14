using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLySanPhamTHTKW
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        QuanLySanPhamTHTKW.App_code.XuLyDuLieu XuLyDuLieu;
        DataTable tbSANPHAM;
        protected void Page_Load(object sender, EventArgs e)
        {
            XuLyDuLieu = new App_code.XuLyDuLieu();
            string masanpham = Request.QueryString.Get("MSP");
            SqlParameter[] pr;
            if (masanpham != null)
                pr = new SqlParameter[] { new SqlParameter("@MASANPHAM", masanpham) };
            else
                pr = new SqlParameter[] { new SqlParameter("@MASANPHAM", DBNull.Value) };

            tbSANPHAM = XuLyDuLieu.getTable("psGetCHITIETSANPHAM", pr);
            Repeater2.DataSource = tbSANPHAM;
            Repeater2.DataBind();

            int soluong = Convert.ToInt32(tbSANPHAM.Rows[0]["SOLUONG"].ToString());
            for (int i = 1; i <= soluong; i++)
                this.drlSOLUONG.Items.Add(i.ToString());
        }

        protected void btn_GIOHANG_Click(object sender, EventArgs e)
        {
            Session.Timeout = 2;
            App_code.CART cart = new App_code.CART();
            if (tbSANPHAM != null)
            {
                String masanpham = tbSANPHAM.Rows[0]["MASANPHAM"].ToString();
                String tensanpham = tbSANPHAM.Rows[0]["TENSANPHAM"].ToString();
                double dongia = Double.Parse(tbSANPHAM.Rows[0]["DONGIA"].ToString());
                String hinhanh = tbSANPHAM.Rows[0]["HINHANH"].ToString();
                int soluong = Int16.Parse(drlSOLUONG.SelectedItem.Text);
                if (Session["CART"] != null)
                    cart = (App_code.CART)Session["CART"];
                cart.AddCart(masanpham, tensanpham, dongia, soluong, hinhanh);
                Session["CART"] = cart;
                Response.Redirect("GioHang.aspx");
            }
        }
    }
}