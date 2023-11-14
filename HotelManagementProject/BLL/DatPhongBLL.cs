using System;
using System.Collections.Generic;
using System.Linq;
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
            
        }
    }
}
