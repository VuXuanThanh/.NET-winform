using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang_nhom1
{
    public partial class frmMain : Form
    {
        public String appPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\images";
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
          
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuQLNCC_Click(object sender, EventArgs e)
        {
            frmDMNhaCC frmNCC = new frmDMNhaCC();
            frmNCC.ShowDialog();
        }

        private void mnuQLNV_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.ShowDialog();
        }

        private void mnuQLKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void tầng1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Image = Image.FromFile(appPath + @"/shit_.jpg");
        }

        private void tầng2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Image = Image.FromFile(appPath + @"/ny_toi.jpg");
        }

        private void tầng3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Image = Image.FromFile(appPath + @"/bandoi.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
