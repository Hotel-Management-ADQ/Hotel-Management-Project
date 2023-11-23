using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        private QLKSDataContext _qLKSDataContext;
        public HoaDonBLL()
        {
            _qLKSDataContext = new QLKSDataContext();
        }
        public List<HoaDonDTO> GetHoaDonList()
        {
            try
            {
                var hoadonList = (from p in _qLKSDataContext.datphongs
                                  select new HoaDonDTO
                                  {
                                      IdDatPhong = p.id_datphong,
                                      IdNhanVien = p.id_nhanvien,
                                      IdKhachHang = p.id_khachhang,
                                      IdPhong = p.id_phong,
                                      CheckIn = p.check_in,
                                      CheckOut = p.check_out,
                                      DatCoc = (double)p.dat_coc,
                                      TienPhong = (double)p.tien_phong,
                                      PhuThuCheckIn = (double)p.phu_thu_checkin,
                                      PhuThuCheckOut = (double)p.phu_thu_checkout,
                                      TongTienDichVu = (double)p.tong_tien_dv,
                                      TongTienThucPham = (double)p.tong_tien_tb,
                                      TongTienHoaDon = (double)p.tong_tien_hoa_don,
                                      TongTien = (double)p.tong_tien,
                                      SoNguoiO = (int)p.so_nguoi_o,
                                      Loai = p.loai,
                                      TrangThai = p.trang_thai
                                  }).ToList();

                return hoadonList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public string LayTenTuKhachHang(string id_KhachHang)
        {
            var khachhang = (from kh in _qLKSDataContext.khachhangs
                       where kh.id_khachhang ==id_KhachHang.Trim()
                       select kh.ten_khachhang).FirstOrDefault();
            return khachhang;
        }

        public DateTime LayNgaySinhTuKhachHang(string id_KhachHang)
        {
            var ngaysinh = (from kh in _qLKSDataContext.khachhangs
                             where kh.id_khachhang == id_KhachHang.Trim()
                             select kh.ngay_sinh).FirstOrDefault();
            return ngaysinh;
        }
    }
}
