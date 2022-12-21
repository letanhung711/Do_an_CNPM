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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        public void TTNV()
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.TTNV();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvnv.Items.Add(dt.Rows[i][0].ToString());
                lvnv.Items[i].SubItems.Add("***********");
                lvnv.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lvnv.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                if (dt.Rows[i][4].ToString() == "0")
                    lvnv.Items[i].SubItems.Add("Nữ");
                else lvnv.Items[i].SubItems.Add("Nam");
                lvnv.Items[i].SubItems.Add(dt.Rows[i][5].ToString());
                lvnv.Items[i].SubItems.Add(dt.Rows[i][6].ToString());
                lvnv.Items[i].SubItems.Add(dt.Rows[i][7].ToString());
            }
        }
        public void TTCV()
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.TTCV();
            cbcv.DataSource = dt;
            cbcv.DisplayMember = "TenCV";
            cbcv.ValueMember = "MaCV";
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            TTNV();
            TTCV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.TTNV_Max();
            string manv = dt.Rows[0][0].ToString();
            txtmanv.Text = (int.Parse(manv.Substring(manv.Length - 2, 2)) + 1).ToString("NV00");
            txttennv.Text = txtdiachi.Text = txtsdt.Text = txtmk.Text = cbcv.Text = "";
            dtpngaysinh.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtmanv.Text.Trim()!= null || txttennv.Text.Trim()!= null || txtdiachi.Text.Trim()!= null || txtmk.Text.Trim()!= null || txtsdt.Text.Trim()!= null || cbcv.Text.Trim()!= null)
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNV = txtmanv.Text;
                nv.TenNV = txttennv.Text;
                nv.MK = txtmk.Text;
                nv.NgaySinh = dtpngaysinh.Value.ToString("MM/dd/yyyy");
                nv.MaCV = cbcv.SelectedValue.ToString();
                nv.DiaChi = txtdiachi.Text;
                nv.SDT = txtsdt.Text;
                if (rdnam.Checked == true) nv.GioiTinh = "1";
                else nv.GioiTinh = "0";
                NhanVienBUS.Them_NV(nv);
                lvnv.Items.Clear();
                TTNV();
            }
            else
            {
                MessageBox.Show("Thiếu thông tin nhân viên. Xin mời nhập thêm!!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.MaNV = txtmanv.Text;
            NhanVienBUS.Xoa_NV(nv);
            lvnv.Items.Clear();
            TTNV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.MaNV = txtmanv.Text;
            nv.TenNV = txttennv.Text;
            nv.MK = txtmk.Text;
            nv.NgaySinh = dtpngaysinh.Value.ToString("MM/dd/yyyy");
            nv.MaCV = cbcv.SelectedValue.ToString();
            nv.DiaChi = txtdiachi.Text;
            nv.SDT = txtsdt.Text;
            if (rdnam.Checked == true) nv.GioiTinh = "1";
            else nv.GioiTinh = "0";
            NhanVienBUS.CapNhat_NV(nv);
            lvnv.Items.Clear();
            TTNV();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtmanv.Text = txttennv.Text = txtdiachi.Text = txtsdt.Text = txtmk.Text = cbcv.Text = "";
            dtpngaysinh.ResetText();
        }

        private void btnTracuu_Click(object sender, EventArgs e)
        {
            lvnv.Items.Clear();
            DataTable dt = new DataTable();
            NhanVienDTO nv = new NhanVienDTO();
            nv.TenNV = txttimkiem.Text;
            dt = NhanVienDAO.TimNV(nv);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvnv.Items.Add(dt.Rows[i][0].ToString());
                lvnv.Items[i].SubItems.Add("***********");
                lvnv.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lvnv.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                if (dt.Rows[i][4].ToString() == "1")
                    lvnv.Items[i].SubItems.Add("Nam");
                else lvnv.Items[i].SubItems.Add("Nữ");
                lvnv.Items[i].SubItems.Add(dt.Rows[i][5].ToString());
                lvnv.Items[i].SubItems.Add(dt.Rows[i][6].ToString());
                lvnv.Items[i].SubItems.Add(dt.Rows[i][7].ToString());
            }
        }

        private void lvnv_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.TTNV_MaNV(lvnv.SelectedItems[0].SubItems[0].Text);

            txtmanv.Text = lvnv.SelectedItems[0].SubItems[0].Text;
            txttennv.Text = lvnv.SelectedItems[0].SubItems[2].Text;
            txtmk.Text = dt.Rows[0][0].ToString();
            dtpngaysinh.Text = lvnv.SelectedItems[0].SubItems[3].Text;
            txtdiachi.Text = lvnv.SelectedItems[0].SubItems[5].Text;
            dt = NhanVienDAO.TenCV(lvnv.SelectedItems[0].SubItems[7].Text);
            cbcv.Text = dt.Rows[0][0].ToString();
            txtsdt.Text = lvnv.SelectedItems[0].SubItems[6].Text;
            if (lvnv.SelectedItems[0].SubItems[4].Text == "Nam") rdnam.Checked = true;
            else rdnu.Checked = true;
        }
    }
}
