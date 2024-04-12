using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_thu_chi_trongthang
{
    class Program
    {
        static void Main(string[] args)
        {
            //GiaoDich gd = new GiaoDich();
            //gd.tao1gd();
            //gd.xuat1gd();

            DanhSachGiaoDich dsgd = new DanhSachGiaoDich();
            int chon;
            do
            {
                Console.WriteLine("nhap gia tri de thuc hien: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        dsgd.them_gd_vao_ds_giaodich();
                        break;
                    case 2:
                        dsgd.xuat_ds_giaodich();
                        break;
                    case 3:
                        dsgd.Tinhtong_theo_danhmuc("an uong");
                        break;
                    case 4:
                        dsgd.xoa_gd_khoi_ds_giaodich();
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
            } while (chon != 0);


<<<<<<< HEAD
=======
            //dsgd.xuat_ds_giaodich();
            double tinhTong = dsgd.Tinhtong_theo_danhmuc("an uong");



            DanhMucChiTieu dm = new DanhMucChiTieu(tinhTong);

            dm.TaoDanhMuc();

            dm.KiemTraVuotMucChiTieu();
>>>>>>> 8c2eebde33ad2c1a864965bd1ca31ccb71b64944



            Console.ReadLine();
        }
    }
}
