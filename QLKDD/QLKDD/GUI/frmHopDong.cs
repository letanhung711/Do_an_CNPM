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
using QLKDD.DTO;
using QLKDD.BUS;

namespace QLKDD.GUI
{
    public partial class frmHopDong : Form
    {
        public frmHopDong()
        {
            InitializeComponent();
        }

        public void Load_tree(TreeView tv)
        {
            TreeNode nodecha = new TreeNode();
            DataTable dt = new DataTable();
            dt = HopDongDAO.TTKH();
            int sokh = dt.Rows.Count;

            DataTable dthd = new DataTable();
            dthd = HopDongDAO.TTHD();
            int sohd = dthd.Rows.Count;

            for (int i = 0; i < sokh; i++)
            {
                nodecha = tv.Nodes.Add(dt.Rows[i]["TenKH"].ToString());
                nodecha.Tag = dt.Rows[i]["MaKH"].ToString();
                for(int j = 0; j < sohd; j++)
                {
                    if(dt.Rows[i]["MaKH"].ToString() == dthd.Rows[j]["MaKH"].ToString())
                    {
                        TreeNode nodecon = new TreeNode();
                        nodecon.Text = "Mã hợp đồng: " + dthd.Rows[j]["MaHD"].ToString();
                        nodecon.Tag = dthd.Rows[j]["MaHD"].ToString();
                        nodecha.Nodes.Add(nodecon);
                    }
                } 
            }
        }
        public void Combobox_KH()
        {
            DataTable dt = new DataTable();
            dt = HopDongDAO.TTKH();
            cbkh.DataSource=dt;
            cbkh.ValueMember = "MaKH";
            cbkh.DisplayMember = "TenKH";
        }
        public void TongHD()
        {
            DataTable dt = new DataTable();
            dt = HopDongDAO.TongHD();
            lbltonghd.Text = dt.Rows[0]["TongHD"].ToString();
        }
        private void frmHopDong_Load(object sender, EventArgs e)
        {
            Load_tree(tvds);
            Combobox_KH();
            TongHD();
        }

        private void tvds_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = HopDongDAO.TTCTHD(tvds.SelectedNode.Tag.ToString());
                txtmahd.Text = dt.Rows[0]["MaHD"].ToString();
                cbkh.Text= dt.Rows[0]["TenKH"].ToString();
                txtmadk.Text= dt.Rows[0]["MaDK"].ToString();
                dtpngayky.Text= dt.Rows[0]["NgayKi"].ToString();
                dtpngayhl.Text = dt.Rows[0]["NgayHieuLuc"].ToString();
            }
            catch { }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DataTable dthd = new DataTable();
            dthd = HopDongDAO.Max_HD();
            string mahd = dthd.Rows[0][0].ToString();
            txtmahd.Text = (int.Parse(mahd.Substring(mahd.Length - 2, 2)) + 1).ToString("HD00");

            DataTable dtdk = new DataTable();
            dtdk = HopDongDAO.Max_DK();
            string madk = dtdk.Rows[0][0].ToString();
            txtmadk.Text= (int.Parse(mahd.Substring(mahd.Length - 1, 1)) + 1).ToString("DK0");
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmahd.Text = cbkh.Text = txtmadk.Text = "";
            dtpngayky.ResetText();
            dtpngayhl.ResetText();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //Them dien ke
            HopDongDTO hd = new HopDongDTO();
            hd.Madk = txtmadk.Text;
            DateTime datenow = new DateTime();
            hd.Ngaykyhd = dtpngayky.Value.ToString("MM/dd/yyyy");
            hd.Ngayhieuluc = dtpngayhl.Value.ToString("MM/dd/yyyy");

            //them hop dong
            hd.Mahd = txtmahd.Text;
            hd.Ngayki = dtpngayky.Value.ToString("MM/dd/yyyy");
            hd.Makh = cbkh.SelectedValue.ToString();
            hd.Madk = txtmadk.Text;

            HopDongBUS.Luu_HD(hd);
            tvds.Nodes.Clear();
            Load_tree(tvds);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            HopDongDTO hd = new HopDongDTO();
            hd.Mahd = txtmahd.Text;
            hd.Madk = txtmadk.Text;
            HopDongBUS.Xoa_HD(hd);
            tvds.Nodes.Clear();
            Load_tree(tvds);
        }
    }
}
