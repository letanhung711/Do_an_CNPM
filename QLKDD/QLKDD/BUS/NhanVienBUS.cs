using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKDD.DAO;
using QLKDD.DTO;

namespace QLKDD.BUS
{
    class NhanVienBUS
    {
        public static void Them_NV(NhanVienDTO nv)
        {
            try
            {
                NhanVienDAO.ThemNV(nv);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thêm nhân viên Dùng Lỗi");
            }
        }
        public static void CapNhat_NV(NhanVienDTO nv)
        {
            try
            {
                NhanVienDAO.CapNhatNV(nv);
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thêm nhân viên Lỗi");
            }
        }
        public static void Xoa_NV(NhanVienDTO nv)
        {
            try
            {
                NhanVienDAO.XoaNV(nv);
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Xóa nhân viên Lỗi");
            }
        }
        public static void CapNhat_ND(NhanVienDTO nv)
        {
            try
            {
                NguoiDungDAO.Sua_ND(nv);
                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }
    }
}
