using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        private QLKSDataContext _qLKSDataContext;
        public NhanVienBLL()
        {
            _qLKSDataContext = new QLKSDataContext();
        }
        public string GetIdNhanVienByTen(string ten)
        {
            var tenLoaiPhong = (from nv in _qLKSDataContext.nhanviens
                                where nv.ten_nhanvien == ten.Trim()
                                select nv.id_nhanvien).FirstOrDefault();
            return tenLoaiPhong;
        }
    }
}
