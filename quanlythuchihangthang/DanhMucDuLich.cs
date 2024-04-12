using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_thu_chi_trongthang
{
    internal class DanhMucDuLich : DanhMucChiTieu
    {
        string _LoaiDuLich;

        public string LoaiDuLich 
        { 
            get => _LoaiDuLich; 
            set
            {
                if (value == "Trong nuoc" || value == "Ngoai nuoc")
                {
                    _LoaiDuLich = value;
                }
                else
                {
                    _LoaiDuLich = "Trong nuoc";
                }
            }
        }

        public DanhMucDuLich () : base () { }

        public DanhMucDuLich (string loaidulich, string tendanhmuc, double mucngansachduocphanbo, double mucchitieu) : base (tendanhmuc, mucngansachduocphanbo, mucchitieu)
        {
            this.LoaiDuLich = loaidulich;
        }

        public override void TaoDanhMuc()
        {
            base.TaoDanhMuc();
            Console.Write("Moi ban nhap loai du lich(Trong nuoc/Ngoai nuoc): ");
            Console.WriteLine();
        }

        public override void XuatDanhMuc()
        {
            base.XuatDanhMuc();
            Console.WriteLine("Loai du lich: {0}", LoaiDuLich);
            Console.WriteLine();
        }


    }
}
