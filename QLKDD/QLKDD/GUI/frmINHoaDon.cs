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
    public partial class frmINHoaDon : Form
    {
        public string mahd;
        public frmINHoaDon()
        {
            InitializeComponent();
        }

        private void frmINHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.IN_HD(mahd);
            CryINHD cry = new CryINHD();
            cry.SetDataSource(dt);
            cryin.ReportSource = cry;
        }
    }
}
