using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKDD.DTO;

namespace QLKDD.DAO
{
    class HopDongDAO
    {
        public static DataTable TongHD()
        {
            string sql = "select COUNT(MaHD) as TongHD from Hopdong";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable Max_DK()
        {
            string sql = "select top 1 MaDK from DienKe order by MaDK desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable Max_HD()
        {
            string sql = "select top 1 MaHD from Hopdong order by MaHD desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTCTHD(string mahd)
        {
            string sql = "select MaHD,TenKH,DienKe.MaDK,NgayKi,NgayHieuLuc from Hopdong,DienKe,KhachHang where Hopdong.MaKH=KhachHang.MaKH and DienKe.MaDK=Hopdong.MaDK and MaHD='"+mahd+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTKH()
        {
            string sql = "select * from KhachHang";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTHD()
        {
            string sql = "select * from Hopdong";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void Luu_HD(HopDongDTO hd)
        {
            string sql = "Insert into Hopdong([MaHD],[MaKH],[MaDK],[NgayKi]) values ('"+hd.Mahd+"','"+hd.Makh+"','"+hd.Madk+"','"+hd.Ngayki+"')";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
        public static void Luu_DK(HopDongDTO hd)
        {
            string sql = "insert into DienKe([MaDK],[NgayKyHD],[NgayHieuLuc]) values ('"+hd.Madk+"','"+hd.Ngaykyhd+"','"+hd.Ngayhieuluc+"')";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
        public static void Xoa_HD(HopDongDTO hd)
        {
            string sql = "delete from Hopdong where MaHD='"+hd.Mahd+"'";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
        public static void Xoa_DK(HopDongDTO hd)
        {
            string sql = "delete from DienKe where MaDK='"+hd.Madk+"'";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
    }
}
