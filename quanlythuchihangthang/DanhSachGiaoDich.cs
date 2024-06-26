﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace quanly_thu_chi_trongthang
{
    public class DanhSachGiaoDich
    {
        List<GiaoDich> dsgiaodich = new List<GiaoDich>();

        public void them_gd_vao_ds_giaodich()
        {
            Console.WriteLine("them giao dich vao danh sach giao dich: ");
            GiaoDich gd = new GiaoDich();
            gd.tao1gd();

            Console.WriteLine("giao dich da duoc them vao danh sach giao dich");
            dsgiaodich.Add(gd);
        }

        public void nhapTuFileXml(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNodeList nodeList = read.SelectNodes("/DanhSach/GiaoDich");
            foreach (XmlNode node in nodeList)
            {
                GiaoDich gd = new GiaoDich();
                gd.Loai = node["Loai"].InnerText;
                gd.Sotien = double.Parse(node["SoTien"].InnerText);
                gd.Mota = node["MoTa"].InnerText;
                gd.Thoigian = node["ThoiGian"].InnerText;
                gd.Danhmuc = node["DanhMuc"].InnerText;
                gd.Motadanhmuc = node["MoTaDM"].InnerText;
                gd.Magd = node["MaGD"].InnerText;
                dsgiaodich.Add(gd);
            }
        }
    

        public void xoa_gd_khoi_ds_giaodich()
        {
            string temp;
            xuat_ds_giaodich();
            Console.WriteLine("nhap magd cua giao dich ban muon xoa: ");
            temp = Console.ReadLine();
            for (int i = 0; i < dsgiaodich.Count(); i++)
            {
                if (dsgiaodich[i].Magd == temp)
                {
                    dsgiaodich.RemoveAt(i);
                    Console.WriteLine("da xoa phan tu co ma: " + temp);
                }
            }
        }



        public void xuat_ds_giaodich()
        {
            for (int i = 0; i < dsgiaodich.Count(); i++)
            {
                Console.WriteLine("giao dich thu " + (i + 1) + " la: ");
                dsgiaodich[i].xuat1gd();
            }
        }



        public virtual double Tinhtong_theo_danhmuc(string loaidanhmuc)
        {
            double sum = 0;
            for (int i = 0; i < dsgiaodich.Count(); i++)
            {
                if (dsgiaodich[i].Danhmuc == loaidanhmuc)
                {
                    sum += dsgiaodich[i].Sotien;
                }
            }
            Console.WriteLine("tong cua ds giao dich: " + sum);
            return sum;
        }

        public virtual double Tinhtong_theo_loai(string loai)
        {
            double sum = 0;
            for (int i = 0; i < dsgiaodich.Count(); i++)
            {
                if (dsgiaodich[i].Loai == loai)
                {
                    sum += dsgiaodich[i].Sotien;
                }
            }
            Console.WriteLine("tong cua ds giao dich: " + sum);
            return sum;
        }
    }
}
