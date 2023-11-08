using System.Collections.Generic;
using System.Data.Linq;
using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;

namespace BLL
{
    public class PhongBLL
    {
        private QLKSDataContext _qLKSDataContext;
        public PhongBLL()
        {
            _qLKSDataContext = new QLKSDataContext();
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
    }

}
