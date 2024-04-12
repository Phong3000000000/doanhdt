using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_thu_chi_trongthang
{
    internal class DanhMucChiTieu
    {
        string _TenDanhMuc;
        double _MucNganSachDuocPhanBo;
        double _MucChiTieu;


        public string TenDanhMuc { get => _TenDanhMuc; set => _TenDanhMuc = value; }
        public double MucNganSachDuocPhanBo { get => _MucNganSachDuocPhanBo; set => _MucNganSachDuocPhanBo = value; }
        public double MucChiTieu { get => _MucChiTieu; set => _MucChiTieu = value; }


        public DanhMucChiTieu() { }

        public DanhMucChiTieu(string tendanhmuc, double mucngansachduocphanbo, double mucchitieu)
        {
            this.TenDanhMuc = tendanhmuc;
            this.MucNganSachDuocPhanBo = mucngansachduocphanbo;
            this.MucChiTieu = mucchitieu;
        }

        public DanhMucChiTieu(DanhMucChiTieu dmct)
        {
            this.TenDanhMuc = dmct.TenDanhMuc;
            this.MucNganSachDuocPhanBo = dmct.MucNganSachDuocPhanBo;
            this.MucChiTieu = dmct.MucChiTieu;
        }


        public void ThongBaoMucChiTieu()
        {
            Console.WriteLine("Muc chi tieu cua danh muc la: {0}", MucChiTieu);
        }


        public void KiemTraVuotMucChiTieu(DanhSachGiaoDich dsgd)
        {
            MucChiTieu = dsgd.Tinhtong_theo_danhmuc("an uong");
            if (MucChiTieu >= MucNganSachDuocPhanBo)
            {
                if (MucChiTieu > MucNganSachDuocPhanBo)
                {
                    double vuotMuc = MucChiTieu - MucNganSachDuocPhanBo;
                    Console.WriteLine("Ban da chi qua muc ngan sach duoc phan bo: {0}", vuotMuc);
                }
                else
                {
                    Console.WriteLine("Ban da chi het khoang tien duoc phan bo!");
                }
                
            }

            else
            {
                double chiTieuAnToan = MucNganSachDuocPhanBo - MucChiTieu;
                Console.WriteLine("Congratulation! Ban da tiet kiem duoc {0} so voi so tien da phan bo!", chiTieuAnToan);
            }
        }

        public virtual void TaoDanhMuc()
        {
            Console.Write("Moi ban nhap ten danh muc: ");
            TenDanhMuc = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Moi ban nhap muc ngan sach duoc phan bo: ");
            MucNganSachDuocPhanBo = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public virtual void XuatDanhMuc()
        {
            Console.WriteLine("Danh muc: {0}", TenDanhMuc);
            Console.WriteLine("Muc ngan sach duoc phan bo: {0}", MucNganSachDuocPhanBo);
            Console.WriteLine();
        }
    }
}
