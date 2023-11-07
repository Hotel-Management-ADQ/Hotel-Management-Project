using System.Linq;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private QLKSDataContext _qLKSDataContext;
        public TaiKhoanBLL()
        {
            _qLKSDataContext = new QLKSDataContext();
        }
        public string GetTenDangNhap(string tendangnhap)
        {
            var account = _qLKSDataContext.taikhoans.FirstOrDefault(nv => nv.ten_dang_nhap == tendangnhap);

            if (account != null)
            {
                return account.ten_dang_nhap;
            }
            else
            {
                return "Không tìm thấy tài khoản";
            }
        }
        public string GetMatKhau(string tendangnhap)
        {
            var account = _qLKSDataContext.taikhoans.FirstOrDefault(nv => nv.ten_dang_nhap == tendangnhap);

            if (account != null)
            {
                return account.mat_khau;
            }
            else
            {
                return "Không tìm thấy tài khoản";
            }
        }
        public int CheckHoatDong(string tendangnhap)
        {
            var account = _qLKSDataContext.taikhoans.FirstOrDefault(nv => nv.ten_dang_nhap == tendangnhap);

            if (account != null)
            {
                return int.Parse(account.hoat_dong.ToString().Trim());
            }
            else
            {
                return 0;
            }
        }
        public bool CheckTaiKhoanTonTai(string tendangnhap)
        {
            var account = _qLKSDataContext.taikhoans.FirstOrDefault(nv => nv.ten_dang_nhap == tendangnhap);
            if (account == null)
                return false;
            else
                return true;
        }
        public string GetTenTaiKhoan(string tendangnhap)
        {
            var query = from t in _qLKSDataContext.taikhoans
                        join n in _qLKSDataContext.nhanviens on t.id_nhanvien equals n.id_nhanvien
                        where t.ten_dang_nhap == tendangnhap
                        select n.ten_nhanvien;

            string tenNhanVien = query.FirstOrDefault();

            return tenNhanVien;
        }

    }
}
