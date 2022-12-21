using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKDD.DTO;

namespace QLKDD.DAO
{
    class TieuThuDAO
    {
        public static DataTable Tim_TT(KhachHangDTO kh)
        {
            string sql = "select MaTieuThu,DienCu,DienMoi,Ngaynhap,MaDK,TenKH,TenNV,(DienMoi-DienCu) as TongTT,TienDien from TieuThu,KhachHang,NhanVien where TieuThu.MaKH=KhachHang.MaKH and TieuThu.MaNV=NhanVien.MaNV and TenKH like '%"+kh.Tenkh+"%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable Max_TT()
        {
            string sql = "select top 1 MaTieuThu from TieuThu order by MaTieuThu desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTTT()
        {
            string sql = "select MaTieuThu,DienCu,DienMoi,Ngaynhap,MaDK,TenKH,TenNV,(DienMoi-DienCu) as TongTT,TienDien from TieuThu,KhachHang,NhanVien where TieuThu.MaKH=KhachHang.MaKH and TieuThu.MaNV=NhanVien.MaNV";
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
        public static DataTable TTNV()
        {
            string sql = "select * from NhanVien";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTDK()
        {
            string sql = "select * from DienKe";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void Xoa_TT(TieuThuDTO tt)
        {
            string sql = "delete from TieuThu where MaTieuThu='"+tt.Matt+"'";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
        public static void Sua_TT(TieuThuDTO tt)
        {
            string sql = "update TieuThu set MaDK='"+tt.Madk+"',MaKH='"+tt.Makh+"',MaNV='"+tt.Manv+"',Ngaynhap='"+tt.Ngaynhap+"',DienCu='"+tt.Diencu+"',DienMoi='"+tt.Dienmoi+"',TienDien='"+tt.Tiendien+"' where MaTieuThu='"+tt.Matt+"'";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
        public static void Luu_TT(TieuThuDTO tt)
        {
            string sql = "Insert into TieuThu([MaTieuThu],[MaDK],[MaKH],[DienCu],[DienMoi],[Ngaynhap],[TienDien],[MaNV]) values ('"+tt.Matt+"','"+tt.Madk+"','"+tt.Makh+"',"+tt.Diencu+","+tt.Dienmoi+",'"+tt.Ngaynhap+"',"+tt.Tiendien+",'"+tt.Manv+"')";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
    }
}
