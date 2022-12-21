using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKDD.DTO;

namespace QLKDD.DAO
{
    class BaoTriDAO
    {
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
        public static DataTable TTBT()
        {
            string sql = "select * from BaoTri";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TimPBT(BaoTriDTO bt)
        {
            string sql = "select * from BaoTri where MaPBaoTri like '%"+bt.Mapbt+"%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTCTNV(string manv)
        {
            string sql = "select TenNV from NhanVien where MaNV='"+manv+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable Max_BT()
        {
            string sql = "select top 1 MaPBaoTri from BaoTri order by MaPBaoTri desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void Luu_BT(BaoTriDTO bt)
        {
            string sql = "Insert into BaoTri([MaPBaoTri],[NgayBT],[TienBT],[LyDo],[MaDK],[MaNV]) values ('"+bt.Mapbt+"','"+bt.Ngaybt+"','"+bt.Tienbt+"',N'"+bt.Lydo+"','"+bt.Madk+"','"+bt.Manv+"')";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
        public static void Xoa_BT(BaoTriDTO bt)
        {
            string sql = "delete from BaoTri where MaPBaoTri='"+bt.Mapbt+"'";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
        public static void CapNhat_BT(BaoTriDTO bt)
        {
            string sql = "update BaoTri set TienBT='"+bt.Tienbt+"',NgayBT='"+bt.Ngaybt+"',LyDo='"+bt.Lydo+"',MaDK='"+bt.Madk+"',MaNV='"+bt.Manv+"' where MaPBaoTri='"+bt.Mapbt+"'";
            KNCSDL.ThucThiCauTruyVan(sql);
        }
    }
}
