using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKDD.DTO;

namespace QLKDD.DAO
{
    class NguoiDungDAO
    {
        public static DataTable TimND(NhanVienDTO nv)
        {
            string sql = "select MaNV,SDT,MK,TenCV from NhanVien,ChucVu where NhanVien.MaCV=ChucVu.MaCV and MaNV like '%"+nv.MaNV+"%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTMK(string manv)
        {
            string sql = "select MK from NhanVien where MaNV='"+manv+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTND()
        {
            string sql = "select MaNV,SDT,MK,TenCV from NhanVien,ChucVu where NhanVien.MaCV=ChucVu.MaCV";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void Sua_ND(NhanVienDTO nv)
        {
            string sql = "update NhanVien set MK='"+nv.MK+"' where MaNV='"+nv.MaNV+"'";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
    }
}
