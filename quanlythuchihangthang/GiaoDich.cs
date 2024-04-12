using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_thu_chi_trongthang
{
    public class GiaoDich
    {
        string magd;
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
        public string Magd { get => magd; set => magd = value; }

        public GiaoDich()
        {
            Magd = "";
            Loai = "";
            Sotien = 1;
            Mota = "";
            Thoigian = "";
            Danhmuc = "";
            Motadanhmuc = "";
        }
        public GiaoDich(string ma, string loaigd, double sotiengd, string motagd, string thoigiangd, string danhmucgd, string motadanhmucgd)
        {
            Magd = ma;
            Loai = loaigd;
            Sotien = sotiengd;
            Mota = motagd;
            Thoigian = thoigiangd;
            Danhmuc = danhmucgd;
            Motadanhmuc = motadanhmucgd;
        }

        public void tao1gd()
        {
            Console.WriteLine("==========================");
            Console.Write("nhap ma cua giao dich: ");
            Magd = Console.ReadLine();
            Console.Write("nhap loai cua giao dich: ");
            Loai = Console.ReadLine();
            Console.Write("nhap so tien cua giao dich: ");
            Sotien = double.Parse(Console.ReadLine());
            Console.Write("nhap mo ta cua giao dich: ");
            Mota = Console.ReadLine();
            Console.Write("nhap thoi gian cua giao dich: ");
            Thoigian = Console.ReadLine();
            Console.Write("nhap danh muc cua giao dich: ");
            Danhmuc = Console.ReadLine();
            Console.Write("nhap mo ta danh muc cua giao dich: ");
            Motadanhmuc = Console.ReadLine();
            Console.Write("==========================");
        }

        public void xuat1gd()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("ma cua giao dich: " + Magd);
            Console.WriteLine("loai cua giao dich: " + Loai);
            Console.WriteLine("so tien cua giao dich: " + Sotien);
            Console.WriteLine("mo ta cua giao dich: " + Mota);
            Console.WriteLine("thoi gian cua giao dich: " + Thoigian);
            Console.WriteLine("danh muc cua giao dich: " + Danhmuc);
            Console.WriteLine("mo ta danh muc cua giao dich: " + Motadanhmuc);
        }




    }
}
