using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_thu_chi_trongthang
{
    internal class DanhMucMuaSam : DanhMucChiTieu
    {
        string _CachThuc;

        public string CachThuc 
        { 
            get => _CachThuc; 
            set
            {
                if (value == "Online" || value == "Offline")
                {
                    _CachThuc = value;
                }
                else
                {
                    _CachThuc = "Online";
                }
            } 
        }
        public DanhMucMuaSam() : base() { }

        public DanhMucMuaSam(string cachthuc, string tendanhmuc, double mucngansachduocphanbo, double mucchitieu) : base(tendanhmuc, mucngansachduocphanbo, mucchitieu)
        {
            this.CachThuc = cachthuc;
        }

        public override void TaoDanhMuc()
        {
            base.TaoDanhMuc();
            Console.Write("Moi ban nhap cach thuc mua sam(Online/Offline): ");
            Console.WriteLine();
        }

        public override void XuatDanhMuc()
        {
            base.XuatDanhMuc();
            Console.WriteLine("Cach thuc mua sam: {0}", CachThuc);
            Console.WriteLine();
        }
    }
}
