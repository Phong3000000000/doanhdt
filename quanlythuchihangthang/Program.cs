using quanlythuchihangthang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_thu_chi_trongthang
{
    class Program
    {
        public static void MenuTongThe()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("bang thao tac tong the: ");
            Console.WriteLine("      ---------          ");
            Console.WriteLine("0. thoat menu");
            Console.WriteLine("1. thao tac voi ngan sach");
            Console.WriteLine("2. thao tac voi cac danh muc");
            Console.WriteLine("3. thao tac voi cac giao dich");
            Console.WriteLine("=========================");
        }

        public static void MenuDanhMuc()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("bang thao tac danh muc: ");
            Console.WriteLine("      ---------          ");
            Console.WriteLine("0. thoat menu");
            Console.WriteLine("1. thao tac voi ");
            Console.WriteLine("2. thao tac voi ");
            Console.WriteLine("3. thao tac voi ");
            Console.WriteLine("=========================");
        }

        public static void MenuGiaoDich()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("bang thao tac cac giao dich: ");
            Console.WriteLine("      ---------          ");
            Console.WriteLine("0. thoat menu");
            Console.WriteLine("1. them giao dich");
            Console.WriteLine("2. xuat ds giao dich");
            Console.WriteLine("3. tinh tong theo danh muc");
            Console.WriteLine("4. xoa giao dich ra khoi dnh sach");
            Console.WriteLine("=========================");
        }

        static void Main(string[] args)
        {
            //GiaoDich gd = new GiaoDich();
            //gd.tao1gd();
            //gd.xuat1gd();

            DanhSachGiaoDich dsgd = new DanhSachGiaoDich();
            int chon;
            do
            {
                MenuGiaoDich();
                Console.WriteLine("nhap gia tri de thuc hien cac chuc nang giao dich: ");
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


            double tinhTong = dsgd.Tinhtong_theo_danhmuc("an uong");



            DanhMucChiTieu dm = new DanhMucChiTieu(tinhTong);

            dm.TaoDanhMuc();

            dm.KiemTraVuotMucChiTieu();

            ThongKe tk = new ThongKe(dsgd);




            Console.ReadLine();
        }

        
    }
}
