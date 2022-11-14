using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLySanPhamTHTKW.App_code.BL
{
    public class bl_QUANLYDANHMUC
    {
        PD.pd_QUANLYDANHMUC pd_quanlydanhmuc;
        Page pageDanhMuc;

        public bl_QUANLYDANHMUC(Page p)
        {
            this.pageDanhMuc = p;
            pd_quanlydanhmuc = new PD.pd_QUANLYDANHMUC();
        }

        public void hienThi()
        {
            ((GridView)this.pageDanhMuc.FindControl("grvDANHMUC")).DataSource = pd_quanlydanhmuc.BangDanhMuc();

            ((GridView)this.pageDanhMuc.FindControl("grvDANHMUC")).DataBind();
        }

        public void themMoi()
        {
            String tenDanhMuc = ((TextBox)this.pageDanhMuc.FindControl("txtTenDanhMuc")).Text;
            int k = pd_quanlydanhmuc.themMoiDanhMuc(tenDanhMuc);
        }

        public void Xoa()
        {
            String maDanhMuc = ((TextBox)this.pageDanhMuc.FindControl("txtMaDanhMuc")).Text;
            int k = pd_quanlydanhmuc.XoaDanhMuc(maDanhMuc);
        }

        public void CapNhat()
        {
            String maDanhMuc = ((TextBox)this.pageDanhMuc.FindControl("txtMaDanhMuc")).Text;
            String tenDanhMuc = ((TextBox)this.pageDanhMuc.FindControl("txtTenDanhMuc")).Text;
            int k = pd_quanlydanhmuc.SuaDanhMuc(maDanhMuc, tenDanhMuc);
        }
    }
}