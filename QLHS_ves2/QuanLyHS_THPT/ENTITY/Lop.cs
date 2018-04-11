using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.ENTITY
{
    class Lop
    {
        private int maLop;
        private string tenLop;
        private int siSo;
        private int maGVCN;

        public int MaLop
        {
            get
            {
                return maLop;
            }

            set
            {
                maLop = value;
            }
        }

        public string TenLop
        {
            get
            {
                return tenLop;
            }

            set
            {
                tenLop = value;
            }
        }

        public int SiSo
        {
            get
            {
                return siSo;
            }

            set
            {
                siSo = value;
            }
        }

        public int MaGVCN
        {
            get
            {
                return maGVCN;
            }

            set
            {
                maGVCN = value;
            }
        }
    }
}
