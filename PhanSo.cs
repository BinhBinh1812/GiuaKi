using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace GiuaKy
{
    public class PhanSo
    {
        private Int32 tuSo;
        private Int32 mauSo;

        public Int32 TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }
        public Int32 MauSo
        {
            get { return mauSo; }
            set
            {
                if (value != 0)
                    mauSo = value;
            }

        }
        public void Nhap()
        {
            Console.WriteLine("Mời bạn nhập tử số: ");
            tuSo = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Mời bạn nhập mẫu số: ");
                mauSo = Convert.ToInt32(Console.ReadLine());
                if (mauSo == 0)
                {
                    Console.WriteLine("Mẫu số phải khác 0. Vui lòng nhập lại!");
                }
            } while (mauSo == 0);

        }
        public void Nhap1tx()
        {
            Console.WriteLine("Mời bạn nhập tử số: ");
            TuSo = Convert.ToInt32(Console.ReadLine());
        }
        //Hàm khởi tạo mặc định
        public PhanSo()
        {
            this.tuSo = 0;
            this.mauSo = 1;
        }
        //Hàm khởi tạo 2 tham số

        public PhanSo(Int32 TuSo, Int32 MauSo)
        {
            this.tuSo = TuSo;
            this.mauSo = MauSo;
        }

        //Hàm khởi tạo 1 tham số

        public PhanSo(Int32 x)
        {
            this.tuSo = x;
            this.mauSo = 1;
        }


        //Cộng hai phân số
        public static PhanSo Cong(PhanSo a, PhanSo b)
        {
            PhanSo Cong = new PhanSo();

            Cong.tuSo = a.tuSo * b.mauSo + a.mauSo * b.tuSo;
            Cong.mauSo = a.mauSo * b.mauSo;
            return Cong;
        }

        //Trừ hai phân số
        public static PhanSo Tru(PhanSo a, PhanSo b)
        {
            PhanSo Tru = new PhanSo();
            Tru.tuSo = a.tuSo * b.mauSo - a.mauSo * b.tuSo;
            Tru.mauSo = a.mauSo * b.mauSo;
            return Tru;
        }

        //Xuất phân số
        public void Xuat()
        {
            //if (mauSo == 1)
            // Console.WriteLine(tuSo);
            //else
            Console.WriteLine(tuSo + "/" + mauSo);
        }

        public Int32 USLN(Int32 a, Int32 b)
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        public void RutGon()
        {
            Int32 uscl = USLN(Math.Abs(tuSo), Math.Abs(mauSo));
            tuSo = tuSo / uscl;
            mauSo = mauSo / uscl;
        }

        //Giá trị số thực của phân số
        //public static PhanSo GiaTri(PhanSo a,PhanSo b)
        //{
        //    float tong = a.tuSo / a.mauSo;
        //    float hieu = b.tuSo / b.mauSo;
        //    return 0;
        //}

        //phân số nghịch đảo
        public void NghichDao(PhanSo a)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = a.mauSo;
            kq.mauSo = a.tuSo;

        }
        public override string ToString()
        {
            return string.Format(tuSo + "/" + mauSo);
        }
    }
}
