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
            dsgd.them_gd_vao_ds_giaodich();
            dsgd.them_gd_vao_ds_giaodich();


            dsgd.xuat_ds_giaodich();
            dsgd.Tinhtong_theo_danhmuc("an uong");



            Console.ReadLine();
        }
    }
}
