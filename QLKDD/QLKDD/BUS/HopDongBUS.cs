using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKDD.DTO;
using QLKDD.DAO;
using System.Windows.Forms;

namespace QLKDD.BUS
{
    class HopDongBUS
    {
        public static void Luu_HD(HopDongDTO hd)
        {
            try
            {
                HopDongDAO.Luu_DK(hd);
                HopDongDAO.Luu_HD(hd);
                MessageBox.Show("Thêm hợp đồng thành công","Thông báo");
            }
            catch
            {
                MessageBox.Show("Thêm không thành công","Thông báo");
            }
        }
        public static void Xoa_HD(HopDongDTO hd)
        {
            try
            {
                HopDongDAO.Xoa_HD(hd);
                HopDongDAO.Xoa_DK(hd);
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
            }
        }
    }
}
