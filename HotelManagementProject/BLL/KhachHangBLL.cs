using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        private QLKSDataContext _qLKSDataContext;
        public KhachHangBLL()
        {
            _qLKSDataContext = new QLKSDataContext();
        }
        public List<khachhang> GetKhachHangList()
        {
            try
            {
                var khachhangList = (from p in _qLKSDataContext.khachhangs select p).ToList();

                return khachhangList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public List<string> GetTenKhachHangList()
        {
            try
            {
                var tenKhachHangList = _qLKSDataContext.khachhangs
                    .Select(kh => kh.ten_khachhang)
                    .ToList();
                return tenKhachHangList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }


        public void XoaKhachHang(string id_khachhang)
        {
            var khachhangToRemove = _qLKSDataContext.khachhangs.SingleOrDefault(dv => dv.id_khachhang == id_khachhang);
            if (khachhangToRemove != null)
            {
                _qLKSDataContext.khachhangs.DeleteOnSubmit(khachhangToRemove);
                _qLKSDataContext.SubmitChanges();
            }
        }

        public void ThemKhachHang(string ten, DateTime ngaysinh, string diachi, string sdt, string cmnd, string gioitinh)
        {
            _qLKSDataContext.Them_Khach_Hang(ten, ngaysinh, diachi, sdt, cmnd, gioitinh);
            _qLKSDataContext.SubmitChanges();
        }

        public void CapNhatKhachHang(string id_khachhang, string ten, DateTime ngaysinh, string diachi, string sdt, string cmnd, string gioitinh)
        {
            var khachhangToUpdate = _qLKSDataContext.khachhangs.SingleOrDefault(kh => kh.id_khachhang == id_khachhang);
            if (khachhangToUpdate != null)
            {
                khachhangToUpdate.ten_khachhang = ten;
                khachhangToUpdate.ngay_sinh = ngaysinh;
                khachhangToUpdate.dia_chi = diachi;
                khachhangToUpdate.sdt = sdt;
                khachhangToUpdate.cmnd = cmnd;
                khachhangToUpdate.gioi_tinh = gioitinh;
                _qLKSDataContext.SubmitChanges();
            }
        }
        public List<khachhang> TimKiemKhachHang(string timkiem)
        {
            var query = from kh in _qLKSDataContext.khachhangs
                        where kh.id_khachhang == timkiem || kh.ten_khachhang == timkiem
                        select kh;

            return query.ToList();
        }
        public string GetTenKhachHangByCMND(string cmnd)
        {
            try
            {
                var tenKhachHang = (from kh in _qLKSDataContext.khachhangs
                                    where kh.cmnd == cmnd
                                    select kh.ten_khachhang).FirstOrDefault();
                return tenKhachHang;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
    }
}
