using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuanLySanPhamTHTKW.App_code.PD
{
    public class pd_QUANLYDANHMUC
    {
        XuLyDuLieu xuLyDuLieu;

        public pd_QUANLYDANHMUC()
        {
            xuLyDuLieu = new XuLyDuLieu();
        }

        public DataTable BangDanhMuc()
        {
            DataTable tb;
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@MaDanhMuc", DBNull.Value);
            tb = xuLyDuLieu.getTable("psGetDanhMuc", pr);
            return tb;
        }

        public int themMoiDanhMuc(String tenDanhMuc)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@TenDanhMuc", tenDanhMuc);
            int k = xuLyDuLieu.Execute("psAddDanhMuc", pr);
            return k;
        }

        public int XoaDanhMuc(String maDanhMuc)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("MaDanhMuc", maDanhMuc);
            int k = xuLyDuLieu.Execute("psDeleteDanhMuc", pr);
            return k;
        }

        public int SuaDanhMuc(String maDanhMuc, String tenDAnhMuc)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@MaDanhMuc", maDanhMuc);
            pr[1] = new SqlParameter("@TenDanhMuc", tenDAnhMuc);
            int k = xuLyDuLieu.Execute("psUpdateDanhMuc", pr);
            return k;
        }
    }
}