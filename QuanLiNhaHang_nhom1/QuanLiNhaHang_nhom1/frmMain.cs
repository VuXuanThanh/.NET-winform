﻿using System;
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
    public partial class frmMain : Form
    {
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

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHD = new frmHoaDon();
            frmHD.ShowDialog();
        }

        private void mnuNguyenLieu_Click(object sender, EventArgs e)
        {
            frmDMNguyenLieu frmNguyenLieu = new frmDMNguyenLieu();
            frmNguyenLieu.ShowDialog();
        }

        private void mnuOrder_Click(object sender, EventArgs e)
        {
            frmGoiMonMain frmGM = new frmGoiMonMain();
            frmGM.ShowDialog();
        }

        private void mnuDanhMuc_Click(object sender, EventArgs e)
        {
            frmDanhMuc frmDM = new frmDanhMuc();
            frmDM.ShowDialog();
        }
    }
}
