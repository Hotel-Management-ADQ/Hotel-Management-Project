using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class ThongKeDichVuBLL
    {
        QLKSDataContext context;
        public ThongKeDichVuBLL()
        {
            context = new QLKSDataContext();
        }
        public List<ChiTietSuDungDichVu> GetThongTinSuDungDichVu()
        {
            var query = from ctsd in context.chitietsudungdvs
                        join dv in context.dichvus on ctsd.id_dichvu equals dv.id_dichvu
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
        public int SoLuongHoaDonTheoThang(int thang)
        {
            int count = context.chitietsudungdvs
                    .Where(dp => dp.ngay_thue.Value.Month == thang)
                    .Count();
            return count;
        }
        public decimal TongTienTheoThang(int nam)
        {
            decimal totalRevenue = context.chitietsudungdvs
                    .Where(dp => dp.ngay_thue.Value.Month == nam)
                    .Sum(dp => (decimal?)dp.tong_tien_dv) ?? 0;

            return totalRevenue;
        }
        public int SoLuongHoaDonTheoQuy(int quy)
        {
            int result = 0;

            try
            {
                result = context.chitietsudungdvs
                    .Where(dp => dp.ngay_thue.Value.Month >= (quy - 1) * 3 + 1 && dp.ngay_thue.Value.Month <= quy * 3)
                    .Count();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return result;
        }
        public decimal TongTienTheoQuy(int quy)
        {
            decimal totalRevenue = context.chitietsudungdvs
                    .Where(dp => dp.ngay_thue.Value.Month >= (quy - 1) * 3 + 1 && dp.ngay_thue.Value.Month <= quy * 3)
                    .Sum(dp => (decimal?)dp.tong_tien_dv) ?? 0;

            return totalRevenue;
        }
        public int SoLuongHoaDonTheoNam(int nam)
        {
            int count = context.chitietsudungdvs
                    .Where(dp => dp.ngay_thue.Value.Year == nam)
                    .Count();
            return count;
        }
        public decimal TongTienTheoNam(int nam)
        {
            decimal totalRevenue = context.chitietsudungdvs
                    .Where(dp => dp.ngay_thue.Value.Year == nam)
                    .Sum(dp => (decimal?)dp.tong_tien_dv) ?? 0;

            return totalRevenue;
        }
    }
}
