using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.ENTITY
{
    class GiaoVien
    {
        private int maGiaoVien;
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string noiSinh;
        private string diaChi;
        private string chuyenMon;
        private string soDienThoai;

        public int MaGiaoVien
        {
            get
            {
                return maGiaoVien;
            }

            set
            {
                maGiaoVien = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public string NoiSinh
        {
            get
            {
                return noiSinh;
            }

            set
            {
                noiSinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string ChuyenMon
        {
            get
            {
                return chuyenMon;
            }

            set
            {
                chuyenMon = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }
    }
}
