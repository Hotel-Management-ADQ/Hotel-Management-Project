using System.Collections.Generic;
using System.Data.Linq;
using System;
using System.Linq;
using DTO;
using System.Runtime.Remoting.Contexts;

namespace BLL
{
    public class PhongBLL
    {
        private QLKSDataContext _qLKSDataContext;
        private readonly PhongDTO _phongDTO;

        public PhongBLL()
        {
            _qLKSDataContext = new QLKSDataContext();
            _phongDTO = new PhongDTO();
        }
        public List<phong> GetPhongList()
        {
            try
            {
                var phongList = (from p in _qLKSDataContext.phongs
                                 select p).ToList();

                return phongList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public List<PhongDTO1> GetPhongDTO1()
        {
            var query = from ph in _qLKSDataContext.phongs
                        join lp in _qLKSDataContext.loaiphongs on ph.id_loaiphong equals lp.id_loaiphong
                        select new PhongDTO1
                        {
                            Idphong = ph.id_phong,
                            Loaiphong = lp.ten_loai,
                            Sotang = ph.id_tang,
                            Tenphong = ph.ten,
                            Trangthai = ph.trang_thai,
                            Gia = ph.gia
                        };

            return query.ToList();
        }

        public List<PhongDTO> GetPhongListCoTenLoaiPhong()
        {
            try
            {
                var phongList = (from p in _qLKSDataContext.phongs
                                 join lp in _qLKSDataContext.loaiphongs on p.id_loaiphong equals lp.id_loaiphong
                                 select new PhongDTO
                                 {
                                     IdPhong = p.id_phong,
                                     TenLoaiPhong = lp.ten_loai,
                                     SoTang = p.id_tang,
                                     TenPhong = p.ten,
                                     TrangThai = p.trang_thai
                                 }).ToList();

                return phongList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public void UpdatePhongTrangThai(string idPhong, string newTrangThai)
        {
            var phongToUpdate = _qLKSDataContext.phongs.SingleOrDefault(p => p.id_phong == idPhong);

            if (phongToUpdate != null)
            {
                phongToUpdate.trang_thai = newTrangThai;
                _qLKSDataContext.SubmitChanges();
            }
        }
        public string GetIdPhongFromRoomPanel(string str)
        {
            return str;
        }
        public string GetTenLoaiPhong(string idPhong)
        {
            var tenLoaiPhong = (from p in _qLKSDataContext.phongs
                                join lp in _qLKSDataContext.loaiphongs on p.id_loaiphong equals lp.id_loaiphong
                                where p.id_phong == idPhong
                                select lp.ten_loai).FirstOrDefault();

            return tenLoaiPhong;
        }
        public string GetTenPhongByIdPhong(string idPhong)
        {
            try
            {
                var tenPhong = (from phong in _qLKSDataContext.phongs
                                where phong.id_phong == idPhong
                                select phong.ten).FirstOrDefault();

                return tenPhong;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
    }

}
