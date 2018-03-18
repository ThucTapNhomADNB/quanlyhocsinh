using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.ENTITY
{
    class HocSinh
    {
        private int maHocSinh;
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string noiSinh;
        private string danToc;
        private string tonGiao;

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

        public string TonGiao
        {
            get
            {
                return tonGiao;
            }

            set
            {
                tonGiao = value;
            }
        }

        public string DanToc
        {
            get
            {
                return danToc;
            }

            set
            {
                danToc = value;
            }
        }
    }
}
