using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang_nhom1
{
    public partial class frmTimKiemHoaDon : Form
    {
        public frmTimKiemHoaDon()
        {
            InitializeComponent();
        }

        private void frmTimKiemHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = frmHoaDon.table;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaHD.Text = dgvHoaDon.Rows[d].Cells[0].Value.ToString();
            //dtpNgayXuat.Value = DateTime.Parse(dgvHoaDon.Rows[d].Cells[2].Value.ToString());
            txtMaNV.Text = dgvHoaDon.Rows[d].Cells[2].Value.ToString();
            txtMaKH.Text = dgvHoaDon.Rows[d].Cells[3].Value.ToString();
            txtTongTien.Text = dgvHoaDon.Rows[d].Cells[4].Value.ToString();
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
