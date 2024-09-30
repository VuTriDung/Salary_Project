using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Company_Project
{
    internal class NhanvienKiemthu : Nhanvien
    {
        public NhanvienKiemthu() : base() { }
        public NhanvienKiemthu(String maso, String hoten, Double luongCB)
            : base(maso, hoten, luongCB) { }
        public override String ToString()
        {
            return $"{base.ToString()}, loaiNV: NKT";
        }
    }
}
