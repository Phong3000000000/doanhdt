using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_thu_chi_trongthang
{
    internal class NganSach
    {
        double hanmucchitieu;
        double chitieuthucte;
        double ngansachconlai;

        public double Hanmucchitieu { get => hanmucchitieu; set => hanmucchitieu = value; }
        public double Chitieuthucte { get => chitieuthucte; set => chitieuthucte = value; }
        public double Ngansachconlai { get => ngansachconlai; set => ngansachconlai = value; }

        public NganSach()
        {
            Hanmucchitieu = 0;
            Chitieuthucte = 0;
            Ngansachconlai = 0;
        }

        public void NhapNganSach()
        {
            Console.WriteLine("Han muc chi tieu cua ban la: ");
            Hanmucchitieu = double.Parse(Console.ReadLine());
            Console.WriteLine("Chi tieu thuc te cua ban la: ");
            Hanmucchitieu = double.Parse(Console.ReadLine());
            Console.WriteLine("Ngan sach con lai cua ban la: ");
            Hanmucchitieu = double.Parse(Console.ReadLine());
        }

        public void HienThiNganSach()
        {
            Console.WriteLine("Han muc chi tieu cua ban la: " + Hanmucchitieu);
            Console.WriteLine("Chi tieu thuc te cua ban la: " + Chitieuthucte);
            Console.WriteLine("Ngan sach con lai cua ban la: " + Ngansachconlai);
        }

        // phương thức kiểm tra vượt mức với tổng của tất cả danh sách danh mục
    }
}
