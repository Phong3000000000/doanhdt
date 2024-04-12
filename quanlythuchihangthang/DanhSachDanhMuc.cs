using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_thu_chi_trongthang
{
    internal class DanhSachDanhMuc
    {
        List<DanhMucChiTieu> DS_DMCT = new List<DanhMucChiTieu>();

        public void nhapDS_DMCT(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (DS_DMCT[i].TenDanhMuc == "an uong")
                {
                    DanhMucAnUong an = new DanhMucAnUong();
                    an.TaoDanhMuc();
                    DS_DMCT.Add(an);
                }

                else if (DS_DMCT[i].TenDanhMuc == "mua sam")
                {
                    DanhMucMuaSam ms = new DanhMucMuaSam();
                    ms.TaoDanhMuc();
                    DS_DMCT.Add(ms);
                }

                else 
                {
                    DanhMucDuLich dl = new DanhMucDuLich();
                    dl.TaoDanhMuc();
                    DS_DMCT.Add(dl);
                }
            }
        }

        public void xuatDS_DMCT()
        {
            foreach(DanhMucChiTieu dmct in DS_DMCT)
            {
                dmct.XuatDanhMuc();
            }
        }
    }
}
