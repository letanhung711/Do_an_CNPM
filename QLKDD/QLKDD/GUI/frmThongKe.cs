using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKDD.DAO;

namespace QLKDD.GUI
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        public void Tongkh()
        {
            DataTable dt = new DataTable();
            dt = ThongKeDAO.TongKH();
            lbltongkh.Text = dt.Rows[0][0].ToString();
        }
        public void Tongkhchuatt()
        {
            DataTable dt = new DataTable();
            dt = ThongKeDAO.TongKHchuaTT();
            lbltongno.Text = dt.Rows[0][0].ToString();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            Tongkh();
            Tongkhchuatt();

        }

        private void btntktt_Click(object sender, EventArgs e)
        {
            lvds.Columns.Clear();
            lvds.Items.Clear();
            lvds.Columns.Add("Mã khách hàng");
            lvds.Columns.Add("Tên khách hàng");
            lvds.Columns.Add("Mã điện kế");
            lvds.Columns.Add("Ngày nhập");
            lvds.Columns.Add("Điện cũ");
            lvds.Columns.Add("Điện mới");
            lvds.Columns.Add("Tổng tiêu thụ");
            DataTable dt = new DataTable();
            dt = ThongKeDAO.TKTieuThu();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                lvds.Items.Add(dt.Rows[i][0].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i][5].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i][6].ToString());
            }
        }

        private void btntkcp_Click(object sender, EventArgs e)
        {
            lvds.Columns.Clear();
            lvds.Items.Clear();
            lvds.Columns.Add("Mã điện kế");
            lvds.Columns.Add("Mã nhân viên");
            lvds.Columns.Add("Ngày bảo trì");
            lvds.Columns.Add("Tiền bảo trì");
            DataTable dt = new DataTable();
            dt = ThongKeDAO.TKChiPhi();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvds.Items.Add(dt.Rows[i][0].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
            }
        }

        private void btntkcn_Click(object sender, EventArgs e)
        {
            lvds.Columns.Clear();
            lvds.Items.Clear();
            lvds.Columns.Add("Mã khách hàng");
            lvds.Columns.Add("Tên khách hàng");
            lvds.Columns.Add("Tiền điện");
            lvds.Columns.Add("Ngày gửi");
            lvds.Columns.Add("Trạng thái");
            DataTable dt = new DataTable();
            dt = ThongKeDAO.TKCongNo();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                 if (dt.Rows[i]["TrangThai"].ToString() == "Chưa thanh toán")
                {
                    lvds.Items.Add(dt.Rows[i]["MaKH"].ToString());
                    lvds.Items[i].SubItems.Add(dt.Rows[i]["TenKH"].ToString());
                    lvds.Items[i].SubItems.Add(dt.Rows[i]["TienDien"].ToString());
                    lvds.Items[i].SubItems.Add(dt.Rows[i]["Ngaygui"].ToString());
                    lvds.Items[i].SubItems.Add(dt.Rows[i]["TrangThai"].ToString());
                }
                    
            }
        }
    }
}
