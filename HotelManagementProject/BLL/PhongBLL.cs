using System.Collections.Generic;
using System.Data.Linq;
using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

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
    }

}
