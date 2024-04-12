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

        public string LoaiDuLich { get => _LoaiDuLich; set => _LoaiDuLich = value; }

        public DanhMucDuLich () : base () { }

        public DanhMucDuLich (string loaidulich, string tendanhmuc, double mucngansachduocphanbo, double mucchitieu) : base (tendanhmuc, mucngansachduocphanbo, mucchitieu)
        {
            this.LoaiDuLich = loaidulich;
        }


    }
}
