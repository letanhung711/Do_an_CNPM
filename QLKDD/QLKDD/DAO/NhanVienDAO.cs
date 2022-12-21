using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKDD.DTO;

namespace QLKDD.DAO
{
    class NhanVienDAO
    {
        public static DataTable KTTK(NhanVienDTO nv)
        {
            string sql = "select * from NhanVien where MaNV = '" + nv.MaNV + "' and MK = '" + nv.MK + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTNV()
        {
            string sql = "select * from NhanVien";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTCV()
        {
            string sql = "select * from ChucVu";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTNV_MaNV(string manv)
        {
            string sql = "select MK from NhanVien where MaNV='" + manv + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TenCV(string macv)
        {
            string sql = "select TenCV from ChucVu where MaCV='"+macv+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTNV_Max()
        {
            string sql = "select top 1 MaNV from NhanVien order by MaNV desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TimNV(NhanVienDTO nv)
        {
            string sql = "select * from NhanVien where TenNV like '%" + nv.TenNV + "%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable CV_ChiTiet(string macv)
        {
            string sql = "select * from ChucVu where MaCV ='" + macv + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }

        public static void ThemNV(NhanVienDTO nv)
        {
            string sql = "insert into NhanVien (MaNV , MK , TenNV , NgaySinh , GioiTinh , DiaChi , SDT , MaCV ) values ('" + nv.MaNV + "' , '" + nv.MK + "' , N'" + nv.TenNV + "' , '" + nv.NgaySinh + "' , '" + nv.GioiTinh + "' , N'" + nv.DiaChi + "' , '" + nv.SDT + "' , N'" + nv.MaCV + "')";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
        public static void CapNhatNV(NhanVienDTO nv)
        {
            string sql = "update NhanVien set MK = '" + nv.MK + "' , TenNV = N'" + nv.TenNV + "' , NgaySinh = '" + nv.NgaySinh + "' , GioiTinh = '" + nv.GioiTinh + "' , DiaChi = N'" + nv.DiaChi + "' , SDT = '" + nv.SDT + "' , MaCV = '" + nv.MaCV + "' where MaNV = '" + nv.MaNV + "'";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
        public static void XoaNV(NhanVienDTO nv)
        {
            string sql = "delete from NhanVien where MaNV = '" + nv.MaNV + "'";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
    }
}
