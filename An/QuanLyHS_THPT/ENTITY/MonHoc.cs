using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.ENTITY
{
    class MonHoc
    {
        private int maMonHoc;
        private string tenMonHoc;

        public int MaMonHoc
        {
            get
            {
                return maMonHoc;
            }

            set
            {
                maMonHoc = value;
            }
        }

        public string TenMonHoc
        {
            get
            {
                return tenMonHoc;
            }

            set
            {
                tenMonHoc = value;
            }
        }
    }
}
