using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHS_THPT.ENTITY
{
    class Account
    {
        private string usename;
        private string password;
        private int maGiaoVien;
        private int phanQuyen;

        public string Usename
        {
            get
            {
                return usename;
            }

            set
            {
                usename = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

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

        public int PhanQuyen
        {
            get
            {
                return phanQuyen;
            }

            set
            {
                phanQuyen = value;
            }
        }
    }
}
