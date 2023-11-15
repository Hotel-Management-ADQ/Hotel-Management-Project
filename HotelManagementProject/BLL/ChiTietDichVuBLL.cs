﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietDichVuBLL
    {
        public QLKSDataContext qLKSDataContext;
        public ChiTietDichVuBLL()
        {
            qLKSDataContext = new QLKSDataContext();
        }
        public List<ChiTietSuDungDichVu> GetThongTinSuDungDichVu()
        {
            var query = from ctsd in qLKSDataContext.chitietsudungdvs
                        join dv in qLKSDataContext.dichvus on ctsd.id_dichvu equals dv.id_dichvu
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
        public void ThemChiTietDichVu(string idhoadon, string iddv, DateTime thoigian, int soluong)
        {
            qLKSDataContext.Them_chi_tiet_su_dung_dv(idhoadon, iddv, thoigian, soluong);
            qLKSDataContext.SubmitChanges();
        }
        public double TinhTongTienDichVuTheoIDDatPhong(string idDatPhong)
        {
            try
            {
                var tongTienDichVu = qLKSDataContext.chitietsudungdvs
                    .Where(ct => ct.id_datphong == idDatPhong)
                    .Sum(ct => ct.tong_tien_dv);

                return (double)tongTienDichVu;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
        public void XoaChiTietSuDungDichVu(string mahd, string madv)
        {
            try
            {
                var chiTiet = qLKSDataContext.chitietsudungdvs
                    .Where(ct => ct.id_datphong == mahd && ct.id_dichvu == madv)
                    .FirstOrDefault();

                if (chiTiet != null)
                {
                    qLKSDataContext.chitietsudungdvs.DeleteOnSubmit(chiTiet);
                    qLKSDataContext.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }
        public void SuaSoLuongChiTietSuDungDichVu(string idDatPhong, string idDichVu, int soLuongMoi)
        {
            try
            {
                var chiTiet = qLKSDataContext.chitietsudungdvs
                    .Where(ct => ct.id_datphong == idDatPhong && ct.id_dichvu == idDichVu)
                    .FirstOrDefault();

                if (chiTiet != null)
                {
                    chiTiet.so_luong = soLuongMoi;
                    qLKSDataContext.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
        }


    }
}
