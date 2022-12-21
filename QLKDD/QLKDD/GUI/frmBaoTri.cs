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
    public partial class frmBaoTri : Form
    {
        public frmBaoTri()
        {
            InitializeComponent();
        }

        public void Combobox_DienKe()
        {
            DataTable dt = new DataTable();
            dt = BaoTriDAO.TTDK();
            cbdk.DataSource = dt;
            cbdk.ValueMember = "MaDK";
            cbdk.DisplayMember = "MaDK";
        }
        public void Combobox_NV()
        {
            DataTable dt = new DataTable();
            dt = BaoTriDAO.TTNV();
            cbnv.DataSource = dt;
            cbnv.ValueMember = "MaNV";
            cbnv.DisplayMember = "TenNV";
        }
        public void TT_BT()
        {
            DataTable dt = new DataTable();
            dt = BaoTriDAO.TTBT();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaPBaoTri"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaDK"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaNV"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TienBT"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["NgayBT"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["LyDo"].ToString());
            }
        }

        private void frmBaoTri_Load(object sender, EventArgs e)
        {
            Combobox_DienKe();
            Combobox_NV();
            TT_BT();
        }

        private void lvds_Click(object sender, EventArgs e)
        {
            txtmabt.Text = lvds.SelectedItems[0].SubItems[0].Text;
            cbdk.Text= lvds.SelectedItems[0].SubItems[1].Text;
            DataTable dt = new DataTable();
            dt = BaoTriDAO.TTCTNV(lvds.SelectedItems[0].SubItems[2].Text);
            cbnv.Text = dt.Rows[0][0].ToString();
            txttienbt.Text= lvds.SelectedItems[0].SubItems[3].Text;
            dtpngaybt.Text= lvds.SelectedItems[0].SubItems[4].Text;
            txtlydo.Text= lvds.SelectedItems[0].SubItems[5].Text;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BaoTriDAO.Max_BT();
            string mapbt = dt.Rows[0][0].ToString();
            txtmabt.Text= (int.Parse(mapbt.Substring(mapbt.Length - 2, 2)) + 1).ToString("BT00");
            txttienbt.Text = txtlydo.Text =cbnv.Text=cbdk.Text= "";
            dtpngaybt.ResetText();

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            BaoTriDTO bt = new BaoTriDTO();
            bt.Mapbt = txtmabt.Text;
            bt.Tienbt = int.Parse(txttienbt.Text);
            bt.Ngaybt = dtpngaybt.Value.ToString("MM/dd/yyyy");
            bt.Lydo = txtlydo.Text;
            bt.Madk = cbdk.SelectedValue.ToString();
            bt.Manv = cbnv.SelectedValue.ToString();
            BaoTriBUS.LuuBT(bt);
            lvds.Items.Clear();
            TT_BT();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            BaoTriDTO bt = new BaoTriDTO();
            bt.Mapbt = txtmabt.Text;
            BaoTriBUS.Xoa_BT(bt);
            lvds.Items.Clear();
            TT_BT();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            BaoTriDTO bt = new BaoTriDTO();
            bt.Mapbt = txtmabt.Text;
            bt.Tienbt = int.Parse(txttienbt.Text);
            bt.Ngaybt = dtpngaybt.Value.ToString("MM/dd/yyyy");
            bt.Lydo = txtlydo.Text;
            bt.Madk = cbdk.SelectedValue.ToString();
            bt.Manv = cbnv.SelectedValue.ToString();
            BaoTriBUS.CapNhat_BT(bt);
            lvds.Items.Clear();
            TT_BT();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmabt.Text = txttienbt.Text = txtlydo.Text = cbnv.Text = cbdk.Text = txttimkiem.Text= "";
            dtpngaybt.ResetText();
        }

        private void btntracuu_Click(object sender, EventArgs e)
        {
            lvds.Items.Clear();
            DataTable dt = new DataTable();
            BaoTriDTO bt = new BaoTriDTO();
            bt.Mapbt = txttimkiem.Text;
            dt = BaoTriDAO.TimPBT(bt);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaPBaoTri"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaDK"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaNV"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TienBT"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["NgayBT"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["LyDo"].ToString());
            }
        }
    }
}
