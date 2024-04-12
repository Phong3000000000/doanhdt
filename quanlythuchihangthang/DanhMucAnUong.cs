using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_thu_chi_trongthang
{
    internal class DanhMucAnUong : DanhMucChiTieu
    {
        string _LoaiAnUong;

        public string LoaiAnUong 
        { 
            get => _LoaiAnUong; 
            set
            {
                if (value == "Man" || value == "Chay")
                {
                    _LoaiAnUong = value;
                }
                else
                {
                    _LoaiAnUong = "Man";
                }
            }
        }

        public DanhMucAnUong() : base() { }

        public DanhMucAnUong(string loaianuong, string tendanhmuc, double mucngansachduocphanbo, double mucchitieu) : base(tendanhmuc, mucngansachduocphanbo, mucchitieu)
        {
            this.LoaiAnUong = loaianuong;
        }

        public override void TaoDanhMuc()
        {
            base.TaoDanhMuc();
            Console.Write("Moi ban nhap loai an uong (Man/Chay): ");
            Console.WriteLine();
        }

        public override void XuatDanhMuc()
        {
            base.XuatDanhMuc();
            Console.WriteLine("Loai an uong: {0}", LoaiAnUong);
            Console.WriteLine();
        }


    }
}
