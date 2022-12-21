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
    class HoaDonBUS
    {
        public static void Luu_HD(HoaDonDTO hd)
        {
            try
            {
                HoaDonDAO.Luu_HD(hd);
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thêm hóa đơn không thành công!", "Thông báo");
            }
        }
        public static void Xoa_HD(HoaDonDTO hd)
        {
            try
            {
                HoaDonDAO.Xoa_HD(hd);
                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thêm hóa đơn không thành công!", "Thông báo");
            }
        }
        public static void Sua_HD(HoaDonDTO hd)
        {
            try
            {
                HoaDonDAO.Sua_HD(hd);
                MessageBox.Show("Sửa hóa đơn thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Sửa hóa đơn không thành công!", "Thông báo");
            }
        }
    }
}
