using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKDD.DAO
{
    class ThongKeDAO
    {
        public static DataTable TKCongNo()
        {
            string sql = "select kh.MaKH,TenKH,TienDien,hd.Ngaygui,NgayThuTien,TrangThai from HoaDon hd,KhachHang kh,TieuThu tt where hd.MaKH=kh.MaKH and hd.MaTieuThu=tt.MaTieuThu";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TKChiPhi()
        {
            string sql = "select MaDK,TenNV,NgayBT,TienBT from BaoTri bt, NhanVien nv where bt.MaNV=nv.MaNV";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TKTieuThu()
        {
            string sql = "select kh.MaKH,TenKH,tt.MaDK,Ngaynhap,DienCu,DienMoi,(DienMoi-DienCu) as TongTT from TieuThu tt,KhachHang kh where tt.MaKH=kh.MaKH";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TongKHchuaTT()
        {
            string sql = "select sum(IIF(TrangThai=N'Chưa thanh toán',1,0)) from HoaDon";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TongKH()
        {
            string sql = "select COUNT(MaKH) as TongKH from KhachHang";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
    }
}
