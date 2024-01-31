using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QuanLy_NhaHang_TDN
{
    public class Const
    {
        #region TrangChu
        public static string timeOnline = "hh:mm:ss";
        #region FrmTrangChu_Load
        public static int Quyen1 = 1;
        public static string NV = "Nhân Viên ";
        public const string Admin = "Admin ";
        public static string DangNhap_TC = " đăng nhập thành công!";
        public static string DangXuat = "Bạn có muốn đăng xuất chứ ?";
        #endregion
        #endregion

        #region THONG_BAO_dung_chung
        public static string Thong_Bao = "Thông báo";
        public static string Bao_Loi = "Báo Lỗi";

        public static string GioiTinhNam = "Nam";
        public static string GioiTinhNu = "Nữ";

        public static string Khong_Co_HinhAnh = "Vui lòng thêm Hình Ảnh";
        public static int dgvDSNV_SelectedRows_Count = 0;
        public static int cbbTimKiem = 0;

        public static int cbbTimKiem_SelectedIndex0 = 0;
        public static int cbbTimKiem_SelectedIndex1 = 1;
        
        public static string ban_Ban = "Bàn cũ";
        public static string ban_Ranh = "Bàn mới";

        public static int i = -1;
        #endregion

        #region QuanLy_NhanVien

        #region InitializeComponent
        public static int cbbChucVuSeIn = 0;

        #endregion

        #region dgvDSNV_CellContentClick
        public static int dgvDSNVsecellscount = 0;
        public static int dgvDSNVsecells = 0;
        public static int dgvMaNV = 0;
        public static int dgvHoTen = 1;
        public static int dgvNam = 2;
        public static int dgvNu = 2;
        public static int dgvEmail = 3;
        public static int dgvSDT = 4;
        public static int dgvNgayVaoLam = 5;
        public static int dgvDiaChi = 6;
        public static int dgvChucVu = 7;
        public static int dgvHinhAnh = 8;
        #endregion

        #region icbtnThemAnh_Click
        public static string NV_ofdFile_InitialDirectory = "C:\\";
        public static string NV_ofdFile_Filter = "Image file (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *jpeg; *.jpe; *jfif; *.png";
        public static int ofdFile_FilterIndex = 2;
        public static string Khong_The_TaiAnh = "Lỗi: Không thể tải ảnh";
        #endregion



        #region btnThemNV_Click
        public static string Khong_Day_Du_ThongTin = "Vui lòng nhập đầy đủ thông tin, Họ Tên, SDT,...!";
        public static string themNVThanhCong = "Thêm nhân viên thành công!";
        public static string themNVThatBai = "Thêm nhân viên thất bại!";
        #endregion

        #region btnSuaNV_Click
        public static string suaNVThanhCong = "Sửa thông tin thành công!";
        public static string suaNVThatBai = "Sửa thông tin thất bại!";
        public static string ChonNVCanSua = "Hãy chọn nhân viên cần sửa";

        #endregion

        #region btnXoaNV_Click
        public static string xoaNVThanhCong = "Xóa nhân viên thành công!";
        public static string xoaNVThatBai = "Xóa nhân viên thất bại!";
        public static string ChonNVCanXoa = "Hãy chọn nhân viên cần xoá";

        public static string xacNhanXoa = "Bạn có muốn xoá nhân viên này không ?";
        public static string NV_admin = "Bạn không thể xoá nhân viên này";
        public static int MaNV_KhongXoa = 1;
        #endregion

        #region NhanVien_DAO
        public static string NV_chuoirong_DAO = "";
        public static string NhanVien_Nam = "Nam";
        public static string NhanVien_Nu = "Nữ";
        #endregion

        #region NhanVien_BUS

        public static string emailbatbuoc = @"^[a-z0-9.-@]*@gmail\.com$";
        public static string phoneN = @"^0\d{9,10}$";
        public static int maxMaNV = 0;

        #endregion

        #endregion

        #region QuanLyTaiKhoan

        #region FrmQLTaiKhoan_Load
        public static string cbbLoaiTK_Display = "TenLoaiTaiKhoan";
        public static string cbbLoaiTK_Value = "MaLoaiTaiKhoan";
        public static string cbbNV_oTK_Display = "TenNV";      
        public static string cbbNV_oTK_Value = "MaNV";
        #endregion

        #region dgvDSTK_CellContentClick
        public static int dgvDSTK_SeCells_Count = 0;
        public static int dgvDSTK_SelectedCells = 0;

        public static int dgvMaTK = 0;
        public static int dgvTenNV = 1;
        public static int dgvTenTK = 2;
        public static int dgvLoaiTK = 3;
        public static int dgvMatKhau = 4;
        #endregion

        #region btnThemTK_Click
        public static string ThongBao_Chua_du_Thong_Tin = "Vui lòng nhập đầy đủ thông tin, TênTK, Mật Khẩu";
        public static string themTK_ThanhCong = "Thêm tài khoản thành công!";
        public static string themTK_ThatBai = "Thêm tài khoản thất bại!";
        public static string themTK_KhongCoNV = "Không có nhân viên để thêm!";
        #endregion

        #region btnSuaTK_Click
        public static int dgvDSTK_SelectedRows_Count = 0;
        public static string ChonTK_Can_Sua = "Hãy chọn tài khoản cần sửa ";
        public static string suaTK_ThanhCong = "Sửa tài khoản thành công!";
        public static string suaTK_ThatBai = "Sửa tài khoản thất bại!";
        #endregion

        #region btnXoaTK_Click
        public static string ChonTK_Can_Xoa = "Hãy chọn tài khoản cần xoá ";
        public static string XacNhan_Xoa = "Bạn có muốn xoá tài khoản này không ?";
        public static string TK_Khong_The_Xoa = "Tài khoản này không thể xoá!";
        public static int MaTK_Khong_The_Xoa = 1;
        public static string XoaTK_ThanhCong = "Xoá tài khoản thành công!";
        public static string XoaTK_ThatBai = "Xoá tài khoản thất bại!";
        #endregion

        #region QLTaiKhoan_BUS

        public static string user = @"^[a-z0-9.-@]+$";

        #endregion

        #endregion

        #region DangKy_dungchung_PASS
        public static int AnPass = '*';
        public static int HienPass = '\0';
        public static string DK_TK_ThanhCong = "Đăng ký tài khoản thành công!";
        public static string DK_TK_ThatBai = "Đăng ký tài khoản thất bại!";
        #endregion

        #region DangNhap
        public static string Chua_Nhap_Ten_va_Pass = "Bạn chưa nhập tên tài khoản và mật khẩu ";
        public static string DN_ThatBai = "Đăng nhập thất bại!";
        public static int Tennv_taiKhoanDTO = 0;
        public static int QuyenMaLoai_taiKhoanDTO = 0;
        public static string Thoat = "Bạn muốn thoát chương trình chứ ?";
        #endregion

        #region DoiMatKhau_QuenMatKhau
        public static string MatKhau_XN = "Mật khẩu xác nhận không đúng";
        public static string DoiMK_new_ThanhCong = "Đã đổi mật khẩu mới thành công!";
        public static string DoiMK_new_ThatBai = "Đổi mật khẩu mới thất bại!";
        #endregion


        //////////

        #region QuanLy_Ban

        public static int dgvDSBan_SelectedRows_Count = 0;

        #region FrmQLBan
        public static bool dgvDSBan_AutoGenerateColumns = false;
        #endregion

        #region Them_Ban
        public static string moi_Nhap_Ban = "Vui lòng nhập tên bàn!";

        public static string them_Ban_Thanh_Cong = "Thêm thành công";
        public static string them_Ban_That_Bai = "Thêm thất bại";
        #endregion

        #region Xoa_Ban

        public static string chon_Ban_Muon_Xoa = "Vui lòng chọn bàn muốn xóa!";
        public static string xac_Nhan_Xoa_Ban = "Bạn có muốn xóa bàn này không?";

        public static string xoa_Ban_Thanh_Cong = "Xóa thành công";
        public static string xoa_Ban_That_Bai = "Xóa thất bại";
        #endregion

        #region Sua_Ban
        public static string chon_Ban_Muon_Sua = "Vui lòng chọn bàn muốn sửa!";

        public static string sua_Ban_Thanh_Cong = "Sửa bàn thành công";
        public static string sua_Ban_That_Bai = "Sửa bàn thất bại";
        #endregion

        #region dgvDSBan_CellContentClick

        public static int dgvMaBan = 0;
        public static int dgvTenBan = 1;
        public static int dgvTrangThaiBan = 2;
        #endregion

        #region DSBan_DAO
        public static string chuoi_rong = "";
        public static string BanCu = "Bàn cũ";
        public static string BanMoi = "Bàn mới";
        #endregion

        #endregion

        #region Bieu_Do

        #region FrmBieuDo_Load

        public static string table_DefaultView_Sort = "THANG ASC";
        public static string chart_Series = "Tổng tiền";
        public static string XValueMember = "THANG";
        public static string YValueMember = "TONGTIEN";

        #endregion

        #region BieuDo_BUS
        public static string table_THANG = "THANG";
        public static string table_TONGTIEN = "TONGTIEN";
        public static string thang_DateTime = "MM/yyyy";
        #endregion

        #endregion

        #region Thong_Ke_Hoa_Don

        #region btnChitietHoaDon_Click

        public static int dgvDSHD_SelectedCells_Count = 0;
        public static string chon_Ma_Hoa_Don = "Vui lòng chọn mã hóa đơn!";

        #endregion

        #region dgvDSHD_CellContentClick

        public static string HD_dgvMaHD = "dgvMaHD";
        public static string HD_dgvTenNV = "dgvTenNV";
        public static string HD_dgvNgayLapHD = "dgvNgayLapHD";

        #endregion

        #endregion

        #region Thong_Ke_Doanh_Thu

        #region FrmThongKeDoanhThu_Load
        public static string cbbNam = "NAM";
        #endregion

        #region cbbNam_SelectedIndexChanged
        public static int tongTienNam = 0;
        public static int danhSachTrongNam_Rows_Count = 0;
        public static string Tong_So_Tien = "TONGTIEN";
        public static string DinhDang = "{0:#,##0}Đ";
        public static string lblTinhTong = "Tổng tiền: ";
        #endregion

        #region TKDoanhThu_BUS
        public static int tong = 0;
        public static string tableDT_MAHD = "MAHD";
        public static string tableDT_TONGTIEN = "TONGTIEN";
        public static string tableDT_SOLUONG = "SOLUONG";
        public static string tableDT_MAMONAN = "MAMONAN";
        public static string tableDT_CHIETKHAU = "CHIETKHAU";
        public static string tableDT_NGAY = "NGAYLAPHD";
        #endregion

        #endregion

        #region Chon_Bao_Cao_Theo_Mon

        public static string cbbTheoLoai_DisplayMember = "TENLOAI";
        public static string cbbTheoLoai_ValueMember = "MALOAI";

        #region TKTheoMon_DAO
        public static int DSMonAn_Thit = 1;
        public static int DSMonAn_HaiSan = 2;
        public static int DSMonAn_RauCu = 3;
        public static int DSMonAn_Nuoc = 4;
        #endregion

        #endregion

        #region Bao_Cao_Hoa_Don
        public static string rptHoaDon = "PM_QuanLy_NhaHang_TDN.rptHoaDon.rdlc";
        public static string rptDatasourceHoaDon = "DSHoaDon";
        #endregion

        #region Bao_Cao_Theo_Mon

        #region TatCaMonAn

        public static string rptTatCaMon = "PM_QuanLy_NhaHang_TDN.rptBaoCaoTheoMon.rdlc";
        public static string rptDatasource_TatCaMon = "DSTatCaMonAn";

        #endregion

        #region Theo_Loai

        public static string rptTheoLoai = "PM_QuanLy_NhaHang_TDN.rptBaoCaoTheoLoaiMonAn.rdlc";
        public static string rptDatasource_TheoLoai = "DSTheoLoaiMonAn";
        public static string rptpa_TheoLoai = "paTenLoai";

        #endregion

        #region Nhom_Theo_Loai

        public static string rptNhomTheoLoai = "PM_QuanLy_NhaHang_TDN.rptBaoCaoTheoMonGroup.rdlc";
        public static string rptDatasource_Nhom = "DSLoaiMonGroup";

        #endregion

        #region LocalReport_SubreportProcessing

        public static string paMaLoai = "paMaLoai";
        public static int MaLoai = 0;
        public static string dataSource_MaLoai = "DSLoaiMonSup";

        #endregion
        #endregion

        #region Chi_Tiet_Hoa_Don
        public static string rptCTHD = "PM_QuanLy_NhaHang_TDN.rptChiTietHoaDon.rdlc";
        public static string rptDatasource_CTHD = "DSChiTietHD";
        public static string paMaHD_CTHD = "paMaHD";
        public static string paTenNV_CTHD = "paTenNV";
        public static string paNgayLapHD_CTHD = "paNgayLap";
        public static string paMaBan_CTHD = "paMaBan";
        public static string paTienThua_CTHD = "paTienThua";
        #endregion

        #region Xuat_HD
        public static string rptXuatHD = "PM_QuanLy_NhaHang_TDN.rptChiTietBanHang.rdlc";
        public static string rptData_XuatHD = "DSChiTietBH";
        public static string paNgayLap_XuatHD = "paNgayLap";
        public static string paMaHD_XuatHD = "paMaHD";
        public static string paTenNV_XuatHD = "paTenNV";
        public static string paMaBan_XuatHD = "paMaBan";
        public static string paTienThua_XuatHD = "paTienThua";
        #endregion

        //////////

        #region QuanLy_MonAn

        public static string QLMA_folderPath = @"../../../MonAn";

        #region FrmQLMonAn_Load

        public static string cbbLoaiMonAn_DisplayMember = "TenLoai";
        public static string cbbLoaiMonAn_ValueMember = "MaLoai";

        #endregion

        #region dgvDSMonAn_CellContentClick

        public static int dgvDSMonAn_SelectedCells_Count = 0;
        public static int dgvDSMonAn_SelectedCells = 0;
        public static int dgvMaMonAn = 0;
        public static int dgvTenMonAn = 1;
        public static int dgvDonGia = 2;
        public static int dgvSoLuong = 3;
        public static int dgvLoaiMonAn = 4;
        public static int row_Cells = 5;
        public static string ChiNhapSo = "Vui lòng nhập số vào ô tìm kiếm.";
        #endregion

        #region Them_Mon

        public static string Them_Mon_Thanh_Cong = "Thêm món thành công";
        public static string Them_Mon_That_Bai = "Thêm món thất bại";
        public static string QLMA_dgvMaMonAn = "dgvMaMonAn";
        public static string QLMA_txtMaMonAn = "{0}";
        public static int QLMA_dgvDSMonAn_Rows_Count = 0;
        public static int QLMA_index = 1;
        public static int QLMA_txtMaMonAn_index_1 = 1;

        #endregion

        #region Sua_Mon

        public static string Sua_Mon_Thanh_Cong = "Sửa món thành công";
        public static string Sua_Mon_That_Bai = "Sửa món thất bại";
        public static string MonAnCanSua = "Hãy chọn món ăn cần sửa";
        public static string ChonMonAnCanXoa = "Hãy chọn món ăn cần xoá";
        public static string NhapDayDuThonTinMonAn = "Vui lòng nhập đầy đủ thông tin món ăn";
        public static string XacNhanXoaMonAn = "Bạn có muốn xoá món ăn này không!";
        #endregion

        #region Xoa_Mon

        public static string Xoa_Mon_Thanh_Cong = "Xóa món thành công";
        public static string Xoa_Mon_That_Bai = "Xóa món thất bại";

        #endregion

        #region icbtnThemAnh_Click

        public static string MA_ofdFile_InitialDirectory = "C:\\";
        public static string MA_ofdFile_Filter = "Image file (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *jpeg; *.jpe; *jfif; *.png";

        #endregion

        #region ChuyenAnhVaoThuMuc

        public static string QLMA_DuongDan = "/";
        public static string QLMA_Duoi_jpg = ".jpg";

        #endregion

        #endregion

        #region BanHang

        public static string BH_VuiLongNhapTien = "Vui lòng nhập tiền của khách!";
        public static string BH_folderPath = @"../../../MonAn";

        #region FrmBanHang_Load
        public static string BH_cbbLoaiMenu_DisplayMember = "TenLoai";
        public static string BH_cbbLoaiMenu_ValueMember = "MaLoai";
        public static string BH_cbbBanTrong_DisplayMember = "TenBan";
        public static string BH_cbbBanTrong_ValueMember = "MaBan";
        #endregion

        #region cbbLoaiMenu_SelectedIndexChanged

        public static string BH_cbbTenMonAn_DisplayMember = "TenMonAn";
        public static string BH_cbbTenMonAn_ValueMember = "MaMonAn";
        public static int cbbLoaiMenu_SelectedIndex0 = 0;
        public static int cbbLoaiMenu_SelectedIndex1 = 1;
        public static int cbbLoaiMenu_SelectedIndex2 = 2;

        #endregion

        #region btnThemMon_Click

        public static string BH_VuiLongNhapSLvaCK = "Vui lòng nhập số lượng và chiết khấu!";
        public static string BH_VuiLongChonBan = "Vui lòng chọn bàn để thêm món!";
        public static string BH_VuiLongNhapLaiSL = "Vui lòng nhập lại số lượng!";
        public static string BH_ThemMonThanhCong = "Thêm món ăn thành công!";
        public static string BH_ThemMonThatBai = "Thêm món ăn thất bại!";
        public static string BH_SoLuongKhongDu = "Số lượng món không đủ!";
        public static int BH_Soluong = 0;

        #endregion

        #region icbtnThemHoaDon_Click

        public static string BH_ds_ThanhToan = "Chưa thanh toán";
        public static string BH_ds_BanTrong = "Đang trống";
        public static string BH_ThemHDThanhCong = "Thêm hóa đơn thành công!";
        public static string BH_ThemHDThatBai = "Bàn chưa thanh toán, vui lòng chọn bàn khác!";

        #endregion

        #region btnSuaMonAn_Click

        public static string BH_VuiLongChonMon = "Vui lòng chọn món ăn!";
        public static int dgvDSMonAnKhachChon_SelectedRows_Count = 0;
        public static string BH_SuaMonThanhCong = "Sửa món ăn thành công!";
        public static string BH_SuaMonThatBai = "Sửa món ăn thất bại!";

        #endregion

        #region btnXoa_Click

        public static string BH_XacNhanXoa = "Bạn có muôn xoá món ăn này không!";
        public static string BH_XoaMonThanhCong = "Xóa món ăn thành công!";
        public static string BH_XoaMonThatBai = "Xóa món ăn thất bại!";

        #endregion

        #region dgvDSHD_SelectionChanged

        public static int dgvDSHD_SelectedCells = 0;
        public static string BH_maHoaDon = "dgvMaHoaDon";
        public static int BH_tongThanhTien = 0;
        public static string BH_Cells_dgvMaHD = "dgvMaHD";
        public static string BH_Cells_dgvTong = "dgvTong";

        #endregion

        #region dgvDSHD_CellContentClick

        public static string BH_labelTrangThai = "Trạng thái";
        public static string BH_lblBan = "dgvMaBan";
        public static string BH_lblThanhToan = "dgvThanhToan";

        #endregion

        #region icbtnThanhToan_Click

        public static string BH_VuiLong_ThanhToan_NhapTien = "Vui lòng chọn bàn cần thanh toán và nhập tiền của khách!";
        public static int tienthua = 0;
        public static string BH_VuiLongNhapDuTien = "Vui lòng nhập đủ tiền!";
        public static string BH_ThanhToanThanhCong = "Thanh toán thành công!";
        public static string BH_ThanhToanThatBai = "Thanh toán thất bại!";

        #endregion

        #region dgvDSMonAnKhachChon_CellContentClick

        public static string BH_TxtMaMonAn = "dgvMaMonAn";
        public static string BH_TxtSoLuong = "dgvSoLuong";
        public static string BH_TxtChietKhau = "dgvChietKhau";
        public static string BH_CbbLoaiMenu = "dgvTenLoai";
        public static string BH_CbbTenMonAn = "dgvTenMonAn";

        #endregion

        #region cbbBanTrong_SelectedIndexChanged

        public static int cbbBanTrong_SelectedIndex = 0;
        public static string BH_DangTrong = "Đang trống";

        #endregion

        #region BanHang_DAO

        public static string BH_ChuaThanhToan = "Chưa thanh toán";
        public static string BH_DaThanhToan = "Đã thanh toán";
        public static string BH_ChuoiRong = "";

        #endregion

        #region cbbTenMonAn_SelectedIndexChanged

        public static string BH_DuongDan = "/";
        public static string BH_Duoi_jpg = ".jpg";

        #endregion

        #endregion

    }
}
