using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKDD.DTO;

namespace QLKDD.DAO
{
    class HoaDonDAO
    {
        public static DataTable IN_HD(string mahd)
        {
            string sql = "select nv.MaNV,TenNV,TenKH,kh.SDT,Dot,DienCu,DienMoi,(DienMoi-DienCu) as Sotieuthu,TienDien from NhanVien nv,KhachHang kh,TieuThu tt,HoaDon hd where nv.MaNV=tt.MaNV and kh.MaKH=hd.MaKH and hd.MaTieuThu=tt.MaTieuThu and MaHD='"+mahd+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TimHD(HoaDonDTO hd)
        {
            string sql = "select * from HoaDon,KhachHang where HoaDon.MaKH=KhachHang.MaKH and MaHD like '%"+hd.Mahd+"%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable Max_HD()
        {
            string sql = "select top 1 MaHD from HoaDon order by MaHD desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTTT()
        {
            string sql = "select * from TieuThu";
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
            string sql = "select * from HoaDon,KhachHang where HoaDon.MaKH=KhachHang.MaKH";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void Xoa_HD(HoaDonDTO hd)
        {
            string sql = "delete from HoaDon where MaHD='"+hd.Mahd+"'";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
        public static void Sua_HD(HoaDonDTO hd)
        {
            string sql = "update HoaDon set Dot='"+hd.Dot+"',TrangThai=N'"+hd.Trangthai+"',NgayDocChiSo='"+hd.Ngaydoccs+"',Ngaygui='"+hd.Ngaygui+"',NgayThuTien='"+hd.Ngaythutien+"',MaKH='"+hd.Makh+"',MaTieuThu='"+hd.Matt+"' where MaHD='"+hd.Mahd+"'";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
        public static void Luu_HD(HoaDonDTO hd)
        {
            string sql = "Insert into HoaDon([MaHD],[Dot],[MaKH],[NgayDocChiSo],[Ngaygui],[NgayThuTien],[MaTieuThu],[TrangThai]) values ('"+hd.Mahd+"',"+hd.Dot+",'"+hd.Makh+"','"+hd.Ngaydoccs+"','"+hd.Ngaygui+"','"+hd.Ngaythutien+"','"+hd.Matt+"',N'"+hd.Trangthai+"')";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
    }
}
