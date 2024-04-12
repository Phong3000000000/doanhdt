using quanly_thu_chi_trongthang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlythuchihangthang
{
    public class ThongKe
    {
        double tongthu;
        double tongchi;
        double soduconlai;


        public ThongKe() 
        {
            Tongthu= 0;
            Tongchi= 0;
            Soduconlai= 0;
        }

        public ThongKe(DanhSachGiaoDich dsgd)
        {
            Tongthu = dsgd.Tinhtong_theo_loai("thu");
            Tongchi = dsgd.Tinhtong_theo_loai("chi");
            Soduconlai = Tongthu - Tongchi;
        }



        public double Tongthu { get => tongthu; set => tongthu = value; }
        public double Tongchi { get => tongchi; set => tongchi = value; }
        public double Soduconlai { get => soduconlai; set => soduconlai = value; }

        public double TinhTongThu(DanhSachGiaoDich dsgd)
        {
            Tongthu = dsgd.Tinhtong_theo_loai("thu");
            return Tongthu;
        }

        public double TinhTongChi(DanhSachGiaoDich dsgd)
        {
            Tongchi = dsgd.Tinhtong_theo_loai("chi");
            return Tongchi;
        }

        public double TinhSoDuConLai(DanhSachGiaoDich dsgd)
        {
            Tongthu = dsgd.Tinhtong_theo_loai("thu");
            Tongchi = dsgd.Tinhtong_theo_loai("chi");
            Soduconlai = Tongthu - Tongchi;
            return Soduconlai;
        }

        public void HienThiTatCaGiaoDich (DanhSachGiaoDich dsgd)
        {
            dsgd.xuat_ds_giaodich();
        }

        public void BangThongKe()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("bang thong ke");
            Console.WriteLine("-------------------------");
            Console.WriteLine("tong thu la: " + Tongthu);
            Console.WriteLine("tong chi la: " + Tongchi);
            Console.WriteLine("so du con lai la: " + Soduconlai);
            Console.WriteLine("=========================");
        }



    }
}
