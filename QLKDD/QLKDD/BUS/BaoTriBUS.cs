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
    class BaoTriBUS
    {
        public static void LuuBT(BaoTriDTO bt)
        {
            try
            {
                BaoTriDAO.Luu_BT(bt);
                MessageBox.Show("Thêm phiếu bảo trì thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thêm phiếu không thành công!");
            }
        }
        public static void CapNhat_BT(BaoTriDTO bt)
        {
            try
            {
                BaoTriDAO.CapNhat_BT(bt);
                MessageBox.Show("Cập nhật phiếu thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }
        public static void Xoa_BT(BaoTriDTO bt)
        {
            try
            {
                BaoTriDAO.Xoa_BT(bt);
                MessageBox.Show("Xóa phiếu bảo trì thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Xóa phiếu không thành công!");
            }
        }
    }
}
