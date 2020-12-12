using System;
using System.Data;

namespace QuanLiNhaHang_nhom1
{
    public class BLL
    {
        //NHACC
        public static DataTable showNCC()
        {
           string sql = "select * from NHACUNGCAP";
            DataTable tblNCC = new DataTable();
            tblNCC = DAL.getTable(sql);
            return tblNCC;
        }

        public static bool testNCC(string maNCC)
        {
            string sql = "select MaNCC from NHACUNGCAP where MaNCC='" + maNCC + "'";
            DataTable table = DAL.getTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void insertNCC(string maNCC, string tenNCC, string diaChi, string dienThoai)
        {
            string sql ="insert into NHACUNGCAP values('"+maNCC+ "',N'" + tenNCC + "',N'" + diaChi + "','" + dienThoai + "')";
            DAL.executeNonQuery(sql);
        }

        public static void updateNCC(string maNCC, string tenNCC, string diaChi, string dienThoai)
        {
            string sql = "update NHACUNGCAP set TenNCC =N'" + tenNCC + "', DiaChi=N'" + diaChi + "', DienThoai='" + dienThoai + "' where MaNCC ='"+maNCC+"'";
            DAL.executeNonQuery(sql);
        }

        public static void deleteNCC(string maNCC)
        {
            string sql = "delete from NHACUNGCAP where MaNCC='" + maNCC + "'";
            DAL.executeNonQuery(sql);
        }
        public static DataTable show1NCC(string maNCC)
        {
            string sql = "select * from NHACUNGCAP where MaNCC ='"+maNCC+"'";
            DataTable tblNCC = new DataTable();
            tblNCC = DAL.getTable(sql);
            return tblNCC;
        }
        // NHANVIEN
        public static DataTable showNV()
        {
            string sql = "select * from NHANVIEN";
            DataTable tblNV = new DataTable();
            tblNV = DAL.getTable(sql);
            return tblNV;
        }
        public static void insertNV(string MaNV, string TenNV, string GioiTinh, DateTime ngaySinh, string DiaChi, String DienThoai, float luongThang, string chucVu)
        {
            string sql = "insert into NHANVIEN values ('" + MaNV + "',N'" + TenNV + "',N'" + GioiTinh + "','" + ngaySinh + "',N'" + DiaChi + "','" + DienThoai + "','" + luongThang + "',N'" + chucVu + "')";
            DAL.executeNonQuery(sql);
        }
        public static bool testNV(string maNV)
        {
            string sql = "select MaNV from NHANVIEN where MaNV='" + maNV + "'";
            DataTable table = DAL.getTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void updateNV(string MaNV, string TenNV, string GioiTinh, DateTime ngaySinh, string DiaChi, String DienThoai, float luongThang, string chucVu)
        {
            string sql = "update NHANVIEN set TenNV=N'" + TenNV + "', GioiTinh=N'" + GioiTinh + "', DiaChi=N'" + DiaChi + "'" +
                ", DienThoai='" + DienThoai + "', LuongThang='" + luongThang + "', ChucVu=N'" + chucVu + "' where MaNV='"+MaNV+"'";
            DAL.executeNonQuery(sql);
        }
        public static void deleteNV(string MaNV)
        {
            string sql = "delete from NHANVIEN where MaNV='" + MaNV + "'";
            DAL.executeNonQuery(sql);
        }
        public static DataTable show1NV(string MaNV)
        {
            string sql = "select * from NHANVIEN where MaNV ='" + MaNV + "'";
            DataTable tblNCC = new DataTable();
            tblNCC = DAL.getTable(sql);
            return tblNCC;
        }
        // KHACHHANG
        public static DataTable showKH()
        {
            string sql = "select * from KHACHHANG";
            DataTable tblKH = new DataTable();
            tblKH = DAL.getTable(sql);
            return tblKH;
        }
        /*string makh, string tenkh, string diachi, string dienthoai, string sodiemTL*/
    }
}
