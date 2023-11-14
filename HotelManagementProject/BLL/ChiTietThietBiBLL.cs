using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietThietBiBLL
    {
        private QLKSDataContext qLKSDataContext;
        public ChiTietThietBiBLL()
        {
            qLKSDataContext = new QLKSDataContext();
        }
        public List<ChiTietSuDungThietBi> GetThongTinSuDungThietBi()
        {
            var query = from ctsd in qLKSDataContext.chitietsudungtbs
                        join dv in qLKSDataContext.thietbis on ctsd.id_thietbi equals dv.id_thietbi
                        select new ChiTietSuDungThietBi
                        {
                            Iddatphong = ctsd.id_datphong,
                            Tenthietbi = dv.ten_thietbi,
                            Ngaythue = (DateTime)ctsd.ngay_thue,
                            Soluong = (int)ctsd.so_luong,
                            Tongtientb = (float)ctsd.tong_tien_tb
                        };

            return query.ToList();
        }
    }
}
