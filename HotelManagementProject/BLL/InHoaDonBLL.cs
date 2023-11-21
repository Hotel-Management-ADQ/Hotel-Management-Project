using DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InHoaDonBLL
    {
        private QLKSDataContext _qLKSDataContext;
        public InHoaDonBLL()
        {
            _qLKSDataContext = new QLKSDataContext();
        }

        //public List<XemHoaDon> viewHoaDon(string iddatphong)
        //{
        //    var hoadon = from xemHoaDon in _qLKSDataContext.XemHoaDons
        //                 where xemHoaDon.datphong == iddatphong
        //                 select xemHoaDon;
        //    return hoadon.ToList();
        //}

        public List<XemHoaDonDTO> viewHoaDon(string idDatPhong)
        {
            var query = from dp in _qLKSDataContext.datphongs
                        join nv in _qLKSDataContext.nhanviens on dp.id_nhanvien equals nv.id_nhanvien
                        join kh in _qLKSDataContext.khachhangs on dp.id_khachhang equals kh.id_khachhang
                        join ph in _qLKSDataContext.phongs on dp.id_phong equals ph.id_phong
                        where dp.id_datphong == idDatPhong
                        select new XemHoaDonDTO
                        {
                            DatPhong = dp.id_datphong,
                            NhanVien = nv.ten_nhanvien,
                            KhachHang = kh.ten_khachhang,
                            Phong = ph.ten,
                            CheckIn = dp.check_in,
                            CheckOut = dp.check_out,
                            DatCoc = (float)dp.dat_coc,
                            TienPhong = (float)dp.tien_phong,
                            PhuThuCheckin = (float)dp.phu_thu_checkin,
                            PhuThuCheckout = (float)dp.phu_thu_checkout,
                            TongTienDV = (float)dp.tong_tien_dv,
                            TongTienTB = (float)dp.tong_tien_tb,
                            TongTienHoaDon = (float)dp.tong_tien_hoa_don,
                            TongTien = (float)dp.tong_tien
                        };

            return query.ToList();
        }

        public string PrintInvoice()
        {
            string htmlContentDefault = @"
<!DOCTYPE html>
<html lang=""en"">
    <head><meta charset=""UTF-8""><title>Hóa đơn khách sạn</title><style>body {margin: 0 auto;width: 500px;}</style></head>
<body>
    <div class=""header"" style=""display: flex; justify-content: space-between;"">
        <div class=""address"">
          <h1>The Three Musketeers Hotel</h1>
          <ul>
            <li><p>140 Lê Trọng Tấn, Tây Thạnh, Tân Phú, TP.HCM</p></li>
            <li><p>0123-456-789</p></li>
            <li><p>hotelthreemusketeers.com.vn</p></li>
          </ul>
        </div>
      </div>
  <div class=""content"">
    <h1 style=""text-align: left;"">HÓA ĐƠN</h1>
    <hr>
    <table>
      <tr>
        <th style=""text-align: left;"">Ngày lập hóa đơn:</th>
        <td>&nbsp;&nbsp;&nbsp; {{NgayLapHoaDon}}</td>
      </tr>
      <tr>
        <th style=""text-align: left;"">Hóa đơn số:</th>
        <td>&nbsp;&nbsp;&nbsp; {{MaHoaDon}}</td>
      </tr>
      <tr>
        <th style=""text-align: left;"">Tên khách hàng:</th>
        <td>&nbsp;&nbsp;&nbsp; {{TenKhachHang}}</td>
      </tr>
      <tr>
        <th style=""text-align: left;"">Nhân viên lập hóa đơn:</th>
        <td>&nbsp;&nbsp;&nbsp; {{TenNhanVien}}</td>
      </tr>
      <tr>
        <th style=""text-align: left;"">Ngày check-in:</th>
        <td>&nbsp;&nbsp;&nbsp; {{CheckIn}}</td>
      </tr>
      <tr>
        <th style=""text-align: left;"">Ngày check-out:</th>
        <td>&nbsp;&nbsp;&nbsp; {{CheckOut}}</td>
      </tr>
      <tr>
        <th style=""text-align: left;"">Tổng số ngày:</th>
        <td>&nbsp;&nbsp;&nbsp; {{TongSoNgay}}</td>
      </tr>
      <tr>
        <th style=""text-align: left;"">Phòng:</th>
        <td>&nbsp;&nbsp;&nbsp; {{TenPhong}}</td>
      </tr>
    </table>
    <hr>
    <h3>Hóa đơn chi tiết sử dụng dịch vụ và thiết bị:</h3>
    <p>Tổng số dịch vụ: <strong>{{TongSoDichVu}} loại dịch vụ đã đăng ký</strong></p>
    <p>Tổng số thiết bị : <strong>{{TongSoThietBi}} loại thiết bị đã chọn</strong></p>


    <p style=""font-style: italic;"">Danh sách sử dụng dịch vụ:</p>
    <table style=""width: 100%;"">
      <thead>
        <tr>
          <th style=""text-align: left;"">STT</th>
          <th style=""text-align: left;"">Tên dịch vụ</th>
          <th style=""text-align: left;"">Số lượng</th>
          <th style=""text-align: left;"">Thời gian</th>
        </tr>
      </thead>
      <tbody>
          <tr>
          <td>{{SttDichVu}}</td>
          <td>{{TenDichVu}}</td>
          <td>{{SoLuongDV}}</td>
          <td>{{ThoiGianDV}}</td>
        </tr>
      </tbody>
    </table>
    <p style=""font-style: italic;"">Danh sách sử dụng thiết bị:</p>
    <table style=""width: 100%;"">
      <thead>
        <tr>
          <th style=""text-align: left;"">STT</th>
          <th style=""text-align: left;"">Tên thiết bị</th>
          <th style=""text-align: left;"">Số lượng</th>
          <th style=""text-align: left;"">Thời gian</th>
        </tr>
      </thead>
      <tbody>
          <tr>
          <td>{{SttThietBi}}</td>
          <td>{{TenThietBi}}</td>
          <td>{{SoLuongTB}}</td>
          <td>{{ThoiGianTB}}</td>
        </tr>
      </tbody>
    </table>
  </div>


  <hr>
  <div class=""header"" style=""display: flex; justify-content: flex-end;"">
    <div style=""text-align: right;"">
      <p>Tổng tiền đặt cọc: &nbsp;&nbsp;&nbsp;</p>
      <p>Tổng tiền phòng: &nbsp;&nbsp;&nbsp;</p>
      <p>Tiền phụ thu check-in: &nbsp;&nbsp;&nbsp;</p>
      <p>Tiền phụ thu check-out: &nbsp;&nbsp;&nbsp;</p>
      <p>Tổng tiền dịch vụ: &nbsp;&nbsp;&nbsp;</p>
      <p>Tổng tiền thiết bị: &nbsp;&nbsp;&nbsp;</p>
      <p>Tổng hóa đơn: &nbsp;&nbsp;&nbsp;</p>
      <p>Tổng tiền cần thanh toán: &nbsp;&nbsp;&nbsp;</p>
    </div>
    <div style=""text-align: right;"">
      <p>{{TienDatCoc}}</p>
      <p>{{TongTienPhong}}</p>
      <p>{{PhuThuCheckIn}}</p>
      <p>{{PhuThuCheckOut}}</p>
      <p>{{TongTienDV}}</p>
      <p>{{TongTienTB}}</p>
      <p>{{TongHoaDon}}</p>
      <p>{{TienThanhToan}}</p>
    </div>
  </div>
  <div class=""footer"">
    <div class=""header"" style=""display: flex; justify-content: space-between;"">
        <div class=""logo"">
            <h3>Nhân viên</h3>
        </div>
        <div class=""address"">
            <h3>Khách hàng</h3>
        </div>
      </div>
  </div>
</body>
</html>
";
            return htmlContentDefault;
        }

    }
}
