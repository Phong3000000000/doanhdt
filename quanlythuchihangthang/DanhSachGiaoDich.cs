using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_thu_chi_trongthang
{
    public class DanhSachGiaoDich
    {
        List<GiaoDich> dsgiaodich = new List<GiaoDich>();

        public void them_gd_vao_ds_giaodich()
        {
            Console.WriteLine("them giao dich vao danh sach giao dich");
            GiaoDich gd = new GiaoDich();
            gd.tao1gd();
            Console.WriteLine("giao dich da duoc them vao danh sach giao dich");
            dsgiaodich.Add(gd);
        }



        public void xuat_ds_giaodich()
        {
            for (int i = 0; i < dsgiaodich.Count(); i++)
            {
                Console.WriteLine("giao dich thu " + (i + 1) + " la: ");
                dsgiaodich[i].xuat1gd();
            }
        }

        public double Tinhtong_theo_danhmuc(string loaidanhmuc)
        {
            double sum = 0;
            for (int i = 0; i < dsgiaodich.Count(); i++)
            {
                if (dsgiaodich[i].Danhmuc == loaidanhmuc)
                {
                    sum += dsgiaodich[i].Sotien;
                }
            }
            return sum;
        }
    }
}
