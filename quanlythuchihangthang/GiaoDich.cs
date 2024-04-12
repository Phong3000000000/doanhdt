using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_thu_chi_trongthang
{
    public class GiaoDich
    {
        string loai;
        double sotien;
        string mota;
        string thoigian;
        string danhmuc;
        string motadanhmuc;

        public string Loai { get => loai; set => loai = value; }
        public double Sotien { get => sotien; set => sotien = value; }
        public string Mota { get => mota; set => mota = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
        public string Danhmuc { get => danhmuc; set => danhmuc = value; }
        public string Motadanhmuc { get => motadanhmuc; set => motadanhmuc = value; }

        public GiaoDich(string loaigd, double sotiengd, string motagd, string thoigiangd, string danhmucgd, string motadanhmucgd)
        {
            Loai = loaigd;
            Sotien = sotiengd;
            Mota = motagd;
            Thoigian = thoigiangd;
            Danhmuc = danhmucgd;
            Motadanhmuc = motadanhmucgd;
        }

        public void nhap1gd()
        {
            Console.WriteLine("nhap loai cua giao dich");
            Loai = Console.ReadLine();
            Console.WriteLine("nhap so tien cua giao dich");
            Sotien = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap mo ta cua giao dich");
            Mota = Console.ReadLine();
            Console.WriteLine("nhap thoi gian cua giao dich");
            Thoigian = Console.ReadLine();
            Console.WriteLine("nhap danh muc cua giao dich");
            Danhmuc = Console.ReadLine();
            Console.WriteLine("nhap mo ta danh muc cua giao dich");
            Motadanhmuc = Console.ReadLine();
        }


    }
}
