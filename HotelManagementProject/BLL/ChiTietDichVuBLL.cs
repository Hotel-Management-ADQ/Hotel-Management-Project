using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietDichVuBLL
    {
        private QLKSDataContext qLKSDataContext;
        public ChiTietDichVuBLL()
        {
            qLKSDataContext = new QLKSDataContext();
        }
        public List<ChiTietSuDungDichVu> GetThongTinSuDungDichVu()
        {
            var query = from ctsd in qLKSDataContext.chitietsudungdvs
                        join dv in qLKSDataContext.dichvus on ctsd.id_dichvu equals dv.id_dichvu
                        select new ChiTietSuDungDichVu
                        {
                            Iddatphong = ctsd.id_datphong,
                            Tendichvu = dv.ten_dichvu,
                            Ngaythue = (DateTime)ctsd.ngay_thue,
                            Soluong = (int)ctsd.so_luong,
                            Tongtiendv = (float)ctsd.tong_tien_dv
                        };

            return query.ToList();
        }
    }
}
