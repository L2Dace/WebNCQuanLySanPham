using QuanLySanPhamTHTKW.App_code.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLySanPhamTHTKW.ADMIN
{
    public partial class pageQuanLyDanhMuc : System.Web.UI.Page
    {
        //App_code.XuLyDuLieu xulydulieu;

        //public void LoadDanhMuc()
        //{
        //    SqlParameter[] pr = new SqlParameter[1];
        //    pr[0] = new SqlParameter("@MaDanhMuc", DBNull.Value);
        //    this.grvDANHMUC.DataSource = xulydulieu.getTable("psGetDanhMuc", pr);
        //    this.grvDANHMUC.DataBind();
        //}
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    xulydulieu = new App_code.XuLyDuLieu();
        //    LoadDanhMuc();
        //}

        //protected void buttonsave_Click(object sender, EventArgs e)
        //{
        //    SqlParameter[] pr = new SqlParameter[1];
        //    pr[0] = new SqlParameter("@TENDANHMUC", txtTenDanhMuc.Text);
        //    int k = xulydulieu.Execute("psAddDanhMuc", pr);
        //    LoadDanhMuc();
        //}

        //protected void grvDANHMUC_PageIndexChanging(object sender, GridViewPageEventArgs e)
        //{
        //    this.grvDANHMUC.PageIndex = e.NewPageIndex;
        //    LoadDanhMuc();
        //}
        bl_QUANLYDANHMUC bl_quanlydanhmuc;
        protected void Page_Load(object sender, EventArgs e)
        {
            bl_quanlydanhmuc = new bl_QUANLYDANHMUC(this);
            bl_quanlydanhmuc.hienThi();
        }

        
        protected void buttonsave_Click(object sender, EventArgs e)
        {
            bl_quanlydanhmuc.themMoi();
            bl_quanlydanhmuc.hienThi();
        }
        protected void grvDANHMUC_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grvDANHMUC.PageIndex = e.NewPageIndex;
            bl_quanlydanhmuc.hienThi();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            bl_quanlydanhmuc.CapNhat();
            bl_quanlydanhmuc.hienThi();
        }

        protected void Delete_btn_Click(object sender, EventArgs e)
        {
            bl_quanlydanhmuc.Xoa();
            bl_quanlydanhmuc.hienThi();
        }
    }
}