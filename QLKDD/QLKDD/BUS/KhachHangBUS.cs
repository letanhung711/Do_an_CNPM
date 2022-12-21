using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKDD.DAO;
using QLKDD.DTO;
using System.Windows.Forms;

namespace QLKDD.BUS
{
    class KhachHangBUS
    {
        public static void LuuKH(KhachHangDTO kh)
        {
            try
            {
                KhachHangDAO.LuuKH(kh);
                MessageBox.Show("Thêm khách hàng thành công!","Thông báo");
            }
            catch
            {
                MessageBox.Show("Thêm khách hàng không thành công!");
            }
        }
        public static void CapNhat_KH(KhachHangDTO kh)
        {
            try
            {
                KhachHangDAO.CapNhatKH(kh);
                MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }
        public static void Xoa_KH(KhachHangDTO kh)
        {
            try
            {
                KhachHangDAO.XoaKH(kh);
                MessageBox.Show("Xóa khách hàng thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Xóa khách hàng không thành công!");
            }
        }
    }
}
