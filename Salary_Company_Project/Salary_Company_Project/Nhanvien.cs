using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Salary_Company_Project
{
    public abstract class Nhanvien
    {
        private String maso;
        public String getMaso() { return maso; }
        public void setMaso(String maso) { this.maso = maso; }

        private String hoten;
        public String getHoten() { return hoten; }
        public void setHoten(String hoten) { this.hoten = hoten; }

        private Double luongCB;
        public Double getLuongCB() { return luongCB; }
        public void setLuongCB(double luongCB) { this.luongCB = luongCB;}

        private ITienthuong phuongthucTinhThuong;
        
        //public  ITienthuong getPhuongThucTinhThuong() { return phuongthucTinhThuong; }
        //public void setLuongCB(double luongCB) { this.luongCB = luongCB; }
        public Double getTienthuong() { return 0; }
        protected Nhanvien() { }
        protected Nhanvien(String maso, String hoten, Double luongCB) 
        {
            this.maso = maso;
            this.hoten = hoten;
            this.luongCB = luongCB;
        }
        protected String toString()
        {
            return $"maso:  {this.maso}, hoten: {this.hoten}";
        }
    }
}
