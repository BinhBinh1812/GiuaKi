using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiuaKy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PhanSo macdinh = new PhanSo();
            PhanSo xts = new PhanSo();
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            PhanSo tong = new PhanSo();
            PhanSo hieu = new PhanSo();

            // PhanSo giatri = new PhanSo();




            Console.WriteLine("Nhập phân số thứ 1: ");
            ps1.Nhap();
            Console.WriteLine("Nhập phân số thứ 2: ");
            ps2.Nhap();
            Console.WriteLine("Nhập phân số thứ 3:");
            xts.Nhap1tx();

            macdinh.ToString();
            Console.WriteLine("Phân số mặc định là:" + macdinh.ToString());
            xts.ToString();
            Console.WriteLine("Khởi tạo 1 tham số là:" + xts.ToString());
            ps1.ToString();
            ps1.RutGon();



            Console.WriteLine("Phân số đầu tiên là:" + ps1.ToString());
            ps1.ToString();
            ps1.RutGon();

            Console.WriteLine("Phân số thứ hai là:" + ps2.ToString());
            ps2.ToString();
            ps2.RutGon();



            tong = PhanSo.Cong(ps1, ps2);
            ps1.ToString();
            Console.Write(" cộng ");
            ps2.ToString();
            Console.Write(" = ");
            tong.RutGon();
            tong.Xuat();
            Console.WriteLine();

            hieu = PhanSo.Tru(ps1, ps2);
            ps1.ToString();
            Console.Write(" trừ ");
            ps2.ToString();
            Console.Write(" = ");
            hieu.RutGon();
            hieu.Xuat();
            Console.WriteLine();



            //tong = PhanSo.GiaTri(ps1, ps2);
            //ps1.ToString();
            //Console.WriteLine("Giá trị trả về số thực là:");

            //hieu = PhanSo.GiaTri(ps1, ps2);
            //ps2.ToString();
            //Console.WriteLine("Giá trị trả về số thực là:");


            Console.ReadLine();
        }
    }
}


