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

        public string LoaiAnUong { get => _LoaiAnUong; set => _LoaiAnUong = value; }

        public DanhMucAnUong() : base() { }

        public DanhMucAnUong(string loaianuong, string tendanhmuc, double mucngansachduocphanbo, double mucchitieu) : base(tendanhmuc, mucngansachduocphanbo, mucchitieu)
        {
            this.LoaiAnUong = loaianuong;
        }
    }
}
