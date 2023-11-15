using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiPhongBLL
    {
        private QLKSDataContext _qLKSDataContext;
        public LoaiPhongBLL()
        {
            _qLKSDataContext = new QLKSDataContext();
        }
       
        public List<string> GetTenLoaiPhongList()
        {
            try
            {
                var tenLoaiPhongList = _qLKSDataContext.loaiphongs
                    .Select(kh => kh.ten_loai)
                    .ToList();
                return tenLoaiPhongList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public int GetIdLoaiPhongByTen(string ten)
        {
            var idloaiphong = (from lp in _qLKSDataContext.loaiphongs
                                where lp.ten_loai == ten
                                select lp.id_loaiphong).FirstOrDefault();
            return idloaiphong;
        }
    }
}
