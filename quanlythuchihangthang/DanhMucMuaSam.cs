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

        public string CachThuc { get => _CachThuc; set => _CachThuc = value; }

        public DanhMucMuaSam() : base() { }

        public DanhMucMuaSam(string cachthuc, string tendanhmuc, double mucngansachduocphanbo, double mucchitieu) : base(tendanhmuc, mucngansachduocphanbo, mucchitieu)
        {
            this.CachThuc = cachthuc;
        }
    }
}
