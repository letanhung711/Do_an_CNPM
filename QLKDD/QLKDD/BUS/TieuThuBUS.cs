using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKDD.DTO;
using QLKDD.DAO;

namespace QLKDD.BUS
{
    class TieuThuBUS
    {
        public static void Luu_TT(TieuThuDTO tt)
        {
            try
            {
                TieuThuDAO.Luu_TT(tt);
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thêm không thành công!","Thông báo");
            }
        }
        public static void Xoa_TT(TieuThuDTO tt)
        {
            try
            {
                TieuThuDAO.Xoa_TT(tt);
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!","Thông báo");
            }
        }
        public static void Sua_TT(TieuThuDTO tt)
        {
            try
            {
                TieuThuDAO.Sua_TT(tt);
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Sửa không thành công!","Thông báo");
            }
        }
    }
}
