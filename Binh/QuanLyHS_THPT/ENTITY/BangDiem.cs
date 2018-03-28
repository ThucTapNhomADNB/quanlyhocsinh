using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.ENTITY
{
    class BangDiem
    {
        private int maHocSinh;
        private int maMon;
        private int hocKi;
        private double diemMieng;
        private double diem15ph;
        private double diem1tiet;
        private double diemCuoiKi;
        private double diemTB;

        public int MaHocSinh
        {
            get
            {
                return maHocSinh;
            }

            set
            {
                maHocSinh = value;
            }
        }

        public int MaMon
        {
            get
            {
                return maMon;
            }

            set
            {
                maMon = value;
            }
        }

        
        public double DiemMieng
        {
            get
            {
                return diemMieng;
            }

            set
            {
                diemMieng = value;
            }
        }

        public double Diem15ph
        {
            get
            {
                return diem15ph;
            }

            set
            {
                diem15ph = value;
            }
        }

        public double Diem1tiet
        {
            get
            {
                return diem1tiet;
            }

            set
            {
                diem1tiet = value;
            }
        }

        public double DiemCuoiKi
        {
            get
            {
                return diemCuoiKi;
            }

            set
            {
                diemCuoiKi = value;
            }
        }

        public double DiemTB
        {
            get
            {
                return diemTB;
            }

            set
            {
                diemTB = value;
            }
        }

        public int HocKi
        {
            get
            {
                return hocKi;
            }

            set
            {
                hocKi = value;
            }
        }
    }
}
