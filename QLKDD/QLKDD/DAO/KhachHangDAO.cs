using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKDD.DTO;
using System.Data;

namespace QLKDD.DAO
{
    class KhachHangDAO
    {
        public static DataTable TTKH()
        {
            string sql = "select MaKH,TenKH,SDT,Tenduong,TenLoai from KhachHang,LoaiKH where KhachHang.MaLoai=LoaiKH.MaLoai";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable Max_KH()
        {
            string sql = "select top 1 MaKH from KhachHang order by MaKH desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TimKH(KhachHangDTO kh)
        {
            string sql = "select MaKH,TenKH,SDT,Tenduong,TenLoai from KhachHang,LoaiKH where KhachHang.MaLoai=LoaiKH.MaLoai and TenKH like '%"+kh.Tenkh+"%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void LuuKH(KhachHangDTO kh)
        {
            string sql = "Insert into KhachHang([MaKH],[TenKH],[SDT],[MaLoai],[Tenduong]) values ('"+kh.Makh+"',N'"+kh.Tenkh+"','"+kh.Sdt+"','"+kh.Maloaikh+"','"+kh.Diachi+"')";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
        public static void XoaKH(KhachHangDTO kh)
        {
            string sql = "delete from KhachHang where MaKH='"+kh.Makh+"'";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
        public static void CapNhatKH(KhachHangDTO kh)
        {
            string sql = "update KhachHang set TenKH='"+kh.Tenkh+"',SDT='"+kh.Sdt+"',MaLoai='"+kh.Maloaikh+"',Tenduong='"+kh.Diachi+"' where MaKH='"+kh.Makh+"'";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
    }
}
