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
        public List<view_datphong2> GetPhieuDatPhong(string idphong)
        {
            var phieuDatPhongList = _qLKSDataContext.view_datphong2s
                    .Where(view => view.ten == idphong && view.trang_thai == "Chưa thanh toán")
                    .ToList();

            return phieuDatPhongList;
        }
    }
}
