using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongHopControll
{
    public class SinhVien
    {
        private string ma, ten, ma_Lop, gT, cCCD;

        public string GT
        {
            get { return gT; }
            set { gT = value; }
        }

        public SinhVien() { }
        public SinhVien(string ma, string ten, string maLop, string gt, string cccd, string ngaySinh) {
            this.ma = ma;
            this.ten = ten;
            this.ma_Lop = maLop;
            this.gT = gt;
            this.cCCD = cccd;
            this.ngaySinh = ngaySinh;
        }

        public string CCCD
        {
            get { return cCCD; }
            set { cCCD = value; }
        }

        public string Ma_Lop
        {
            get { return ma_Lop; }
            set { ma_Lop = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        string ngaySinh;

        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        
    }
}
