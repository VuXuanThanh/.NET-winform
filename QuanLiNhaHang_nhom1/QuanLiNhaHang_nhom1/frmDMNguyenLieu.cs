using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang_nhom1
{
    public partial class frmDMNguyenLieu : Form
    {
        public frmDMNguyenLieu()
        {
            InitializeComponent();
        }
        private void resetValue()
        {
            txtMaNL.Text = "";
            txtTenNL.Text = "";
            txtHanSuDung.Text = "";
            cbxDonViTinh.Text = "";
            txtSoLuongTonKho.Text = "";
        }
        private void loadDataGridView()
        {
            DataTable table = new DataTable();
            table = BLL.showNguyenLieu();
            dgvNguyenLieu.DataSource = table;
        }
        private void frmDMNguyenLieu_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            DataTable tbl = new DataTable();
            tbl = BLL.fillComboMaNCC();
            cbxMaNCC.DataSource = tbl;
            cbxMaNCC.ValueMember = "MaNCC";
            cbxMaNCC.DisplayMember = "MaNCC";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            resetValue();
            txtTenNL.Focus();
        }

        private void txtTenNL_TextChanged(object sender, EventArgs e)
        {
           // txtMaNL.Text = txtTenNL.Text.Trim().ToUpper();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNL.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nguyên liệu");
                txtTenNL.Focus();
                return;
            }
            if (txtHanSuDung.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nguyên liệu");
                txtHanSuDung.Focus();
                return;
            }
            if (cbxDonViTinh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đơn vị tính");
                cbxDonViTinh.Focus();
                return;
            }
            if (txtSoLuongTonKho.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nguyên liệu");
                txtSoLuongTonKho.Focus();
                return;
            }
            if (cbxMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp");
                cbxMaNCC.Focus();
                return;
            }

            txtMaNL.Text = NonUnicode(txtTenNL.Text.ToUpper()).Replace(" ","");
            BLL.insertNguyenLieu(txtMaNL.Text, txtTenNL.Text, dtpNgayNhap.Value.Date, int.Parse(txtHanSuDung.Text), cbxDonViTinh.Text, int.Parse(txtSoLuongTonKho.Text), cbxMaNCC.Text);
            loadDataGridView();
            resetValue();
        }
        public string NonUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
    }
}
