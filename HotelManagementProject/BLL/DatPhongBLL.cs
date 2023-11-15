using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DatPhongBLL
    {
        private QLKSDataContext _qLKSDataContext;
        public DatPhongBLL()
        {
            _qLKSDataContext = new QLKSDataContext();
        }
        public string GetTenPhong(string id)
        {
            try
            {
                var tenPhong = (from p in _qLKSDataContext.phongs
                                where p.id_phong == id
                                select p.ten).FirstOrDefault();

                return tenPhong;
            }
            catch (Exception ex)
            {
                return "Lỗi khi truy vấn dữ liệu" + ex;
            }
        }
        public string GetGiaPhong(string id)
        {
            try
            {
                var tenPhong = (from p in _qLKSDataContext.phongs
                                where p.id_phong == id.Trim()
                                select p.gia).FirstOrDefault();

                return tenPhong.ToString().Trim();
            }
            catch (Exception ex)
            {
                return "Lỗi khi truy vấn dữ liệu" + ex;
            }
        }
        //public List<view_datphong2> GetPhieuDatPhong(string idphong)
        //{
        //    var phieuDatPhongList = _qLKSDataContext.view_datphong2s
        //            .Where(view => view.ten == idphong && view.trang_thai == "Chưa thanh toán")
        //            .ToList();

        //    return phieuDatPhongList;
        //}

        public List<PhieuDatPhongDTO> GetPhieuDatPhong(string ten)
        {
            try
            {
                var phieuDatPhongList = _qLKSDataContext.view_datphong2s
                    .Select(view => new PhieuDatPhongDTO
                    {
                        IdDatPhong = view.id_datphong,
                        TenPhong = view.ten,
                        TenNhanVien = view.ten_nhanvien,
                        TenKhachHang = view.ten_khachhang,
                        Loai = view.loai,
                        CheckIn = view.check_in,
                        CheckOut = view.check_out,
                        TongThoiGian = (int)view.tong_thoi_gian,
                        TrangThai = view.trang_thai
                    })
                    .Where(view => view.TenPhong == ten && view.TrangThai == "Chưa thanh toán")
                    .ToList();

                return phieuDatPhongList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }


        public void DatPhong(string idnhanvien, string idkh, string idphong, DateTime checkin,
            DateTime checkout, int songuoi, string loaithue, double datcoc)
        {
            _qLKSDataContext.Dat_Phong(idnhanvien, idkh, idphong, checkin, checkout, songuoi, loaithue, datcoc);
            _qLKSDataContext.SubmitChanges();
        }

        public void UpdateTrangThaiPhong(string id)
        {
            _qLKSDataContext.Update_TrangThaiPhong_1(id);
            _qLKSDataContext.SubmitChanges();
        }

        public string LayIdDatPhongChuaThanhToan(string maphong)
        {
            try
            {
                var idDatPhong = _qLKSDataContext.datphongs
                    .Where(dp => dp.id_phong == maphong && dp.trang_thai == "Chưa thanh toán")
                    .Select(dp => dp.id_datphong)
                    .FirstOrDefault();

                return idDatPhong;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public string GetTenNhanVienByIDDatPhong(string iddatphong)
        {
            try
            {
                var tenNhanVien = (from dp in _qLKSDataContext.datphongs
                                   join nv in _qLKSDataContext.nhanviens on dp.id_nhanvien equals nv.id_nhanvien
                                   where dp.id_datphong == iddatphong
                                   select nv.ten_nhanvien).FirstOrDefault();

                return tenNhanVien;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public string GetTenKhachHangByIDDatPhong(string iddatphong)
        {
            try
            {
                var tenKhachHang = (from dp in _qLKSDataContext.datphongs
                                   join kh in _qLKSDataContext.khachhangs on dp.id_khachhang equals kh.id_khachhang
                                   where dp.id_datphong == iddatphong
                                   select kh.ten_khachhang).FirstOrDefault();

                return tenKhachHang;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public string GetLoaiThueByIDDatPhong(string iddatphong)
        {
            try
            {
                var loaithue = (from dp in _qLKSDataContext.datphongs
                                    where dp.id_datphong == iddatphong
                                    select dp.loai).FirstOrDefault();

                return loaithue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public int GetSoNguoiOByIDDatPhong(string iddatphong)
        {
            try
            {
                var loaithue = (from dp in _qLKSDataContext.datphongs
                                where dp.id_datphong == iddatphong
                                select dp.so_nguoi_o).FirstOrDefault();

                return (int)loaithue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public double GetTienDatCocIDDatPhong(string iddatphong)
        {
            try
            {
                var loaithue = (from dp in _qLKSDataContext.datphongs
                                where dp.id_datphong == iddatphong
                                select dp.dat_coc).FirstOrDefault();

                return (double)loaithue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public DateTime GetCheckInIDDatPhong(string iddatphong)
        {
            try
            {
                var checkin = (from dp in _qLKSDataContext.datphongs
                                where dp.id_datphong == iddatphong
                                select dp.check_in).FirstOrDefault();

                return (DateTime)checkin;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public DateTime GetCheckOutIDDatPhong(string iddatphong)
        {
            try
            {
                var checkout = (from dp in _qLKSDataContext.datphongs
                               where dp.id_datphong == iddatphong
                               select dp.check_out).FirstOrDefault();

                return (DateTime)checkout;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public string GetTrangThaiHoaDonByIDDatPhong(string iddatphong)
        {
            try
            {
                var trangthaiHD = (from dp in _qLKSDataContext.datphongs
                                where dp.id_datphong == iddatphong
                                select dp.trang_thai).FirstOrDefault();

                return trangthaiHD;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public int LayGiaPhongByIDDatPhong(string idDatPhong)
        {
            try
            {
                var giaPhong = (from dp in _qLKSDataContext.datphongs
                                join p in _qLKSDataContext.phongs on dp.id_phong equals p.id_phong
                                where dp.id_datphong == idDatPhong
                                select p.gia).FirstOrDefault();

                return giaPhong;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }


    }
}
