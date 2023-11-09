using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThietBiBLL
    {
        private QLKSDataContext _qLKSDataContext;
        public ThietBiBLL()
        {
            _qLKSDataContext = new QLKSDataContext();
        }
        public List<thietbi> GetThietBiList()
        {
            try
            {
                var thietbiList = (from p in _qLKSDataContext.thietbis select p).ToList();

                return thietbiList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }

        public void XoaThietBi(string id_thietbi)
        {
            var thietbiToRemove = _qLKSDataContext.thietbis.SingleOrDefault(tb => tb.id_thietbi == id_thietbi);
            if (thietbiToRemove != null)
            {
                _qLKSDataContext.thietbis.DeleteOnSubmit(thietbiToRemove);
                _qLKSDataContext.SubmitChanges();
            }
        }

        public void ThemThietBi(string tentb, int gia)
        {
            _qLKSDataContext.Them_Thiet_Bi(tentb, gia);
            _qLKSDataContext.SubmitChanges();
        }
        public void CapNhatThietBi(string id_thietbi, string ten_thietbi, int gia)
        {
            var dichvuToUpdate = _qLKSDataContext.thietbis.SingleOrDefault(dv => dv.id_thietbi == id_thietbi);
            if (dichvuToUpdate != null)
            {
                dichvuToUpdate.ten_thietbi = ten_thietbi;
                dichvuToUpdate.gia = gia;
                _qLKSDataContext.SubmitChanges();
            }
        }
        public List<thietbi> TimKiemThietBi(string timkiem)
        {
            var query = from tb in _qLKSDataContext.thietbis
                        where tb.id_thietbi == timkiem || tb.ten_thietbi == timkiem
                        select tb;

            return query.ToList();
        }

    }
}
