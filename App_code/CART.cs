using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLySanPhamTHTKW.App_code
{
    public class CART
    {
        Dictionary<string, ITEM> listcart;

       

        public Dictionary<string, ITEM> LISTCART
        {
            get { return this.listcart; }
        }

        public CART()
        {
            listcart = new Dictionary<string, ITEM>();
        }

        public void AddCart (String masanpham, String tensanpham, double dongia, int soluong, String hinhanh )
        {
            ITEM item = new ITEM(masanpham, tensanpham, dongia, soluong, hinhanh);

            if (listcart.ContainsKey(item.Masanpham))
                listcart[item.Masanpham].Soluong += item.Soluong;
            else
                listcart.Add(item.Masanpham, item);
        }

        public void RemoveCart(String masanpham)
        {
            listcart.Remove(masanpham);
        }

        public Double TotalBill()
        {
            double total = 0;
            foreach (ITEM item in listcart.Values)
                total += item.THANHTIEN;
            return total;
        }
    }
}