using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DichVuBLL
    {

        private QLKSDataContext _qLKSDataContext;
        public DichVuBLL()
        {
            _qLKSDataContext = new QLKSDataContext();
        }
        public List<dichvu> GetDichVuList()
        {
            try
            {
                var dichvuList = (from p in _qLKSDataContext.dichvus select p).ToList();

                return dichvuList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
        public void XoaDichVu(string id_dichvu)
        {
            var dichvuToRemove = _qLKSDataContext.dichvus.SingleOrDefault(dv => dv.id_dichvu == id_dichvu);
            if (dichvuToRemove != null)
            {
                _qLKSDataContext.dichvus.DeleteOnSubmit(dichvuToRemove);
                _qLKSDataContext.SubmitChanges();
            }
        }
        public void ThemDichVu(string tendv, int gia)
        {
            _qLKSDataContext.Them_Dich_Vu(tendv, gia);
            _qLKSDataContext.SubmitChanges();
        }
        public void CapNhatDichVu(string id_dichvu, string ten_dichvu, int gia)
        {
            var dichvuToUpdate = _qLKSDataContext.dichvus.SingleOrDefault(dv => dv.id_dichvu == id_dichvu);
            if (dichvuToUpdate != null)
            {
                dichvuToUpdate.ten_dichvu = ten_dichvu;
                dichvuToUpdate.gia = gia;
                _qLKSDataContext.SubmitChanges();
            }
        }
        public List<dichvu> TimKiemDichVu(string timkiem)
        {
            var query = from dv in _qLKSDataContext.dichvus
                        where dv.id_dichvu == timkiem || dv.ten_dichvu == timkiem
                        select dv;

            return query.ToList();
        }

    }
}
