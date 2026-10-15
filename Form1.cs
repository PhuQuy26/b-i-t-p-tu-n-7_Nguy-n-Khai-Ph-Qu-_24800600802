using QuanLySinhVien.BLL.DTOs;
using QuanLySinhVien.BLL.Exceptions;
using QuanLySinhVien.BLL.Services;

namespace QuanLySinhVien.UI;

public partial class Form1 : Form
{
    // UI chỉ biết BLL (Service + DTO), không biết EF Core hay DAL.
    private readonly SinhVienService _service = new();

    public Form1()
    {
        InitializeComponent();
    }

    private async void Form1_Load(object? sender, EventArgs e)
    {
        lblTrangThai.Text = "Sẵn sàng. Hãy chạy Migration trước khi dùng (xem README.md).";
        await TaiDanhSach();
    }

    // ===== Hiển thị thông báo trạng thái =====
    private void HienThongBao(string noiDung, bool loi = false)
    {
        lblTrangThai.Text = noiDung;
        lblTrangThai.ForeColor = loi ? Color.Red : Color.DarkGreen;
    }

    private void HienLoi(Exception ex)
    {
        if (ex is BusinessException)
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        HienThongBao("Lỗi: " + ex.Message, loi: true);
    }

    private void DoDuLieuLenLuoi(List<SinhVienDTO> ds)
    {
        dgvSinhVien.DataSource = null;
        dgvSinhVien.DataSource = ds;
    }

    // ===== READ =====
    private async Task TaiDanhSach()
    {
        try
        {
            List<SinhVienDTO> ds = await _service.LayTatCaAsync();
            DoDuLieuLenLuoi(ds);
            HienThongBao($"Đã tải {ds.Count} sinh viên.");
        }
        catch (Exception ex)
        {
            HienLoi(ex);
        }
    }

    private async void btnTaiLai_Click(object? sender, EventArgs e)
    {
        await TaiDanhSach();
    }

    // ===== Chọn dòng -> hiển thị lên ô nhập liệu =====
    private void dgvSinhVien_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvSinhVien.CurrentRow?.DataBoundItem is SinhVienDTO sv)
        {
            txtHoTen.Text = sv.FullName;
            txtDiem.Text = sv.Grade.ToString();
        }
    }

    // ===== CREATE =====
    private async void btnThem_Click(object? sender, EventArgs e)
    {
        if (!double.TryParse(txtDiem.Text, out double diem))
        {
            MessageBox.Show("Điểm không hợp lệ!");
            return;
        }

        try
        {
            await _service.ThemAsync(txtHoTen.Text, diem);

            HienThongBao("Đã thêm sinh viên mới!");
            txtHoTen.Clear();
            txtDiem.Clear();
            await TaiDanhSach();
        }
        catch (Exception ex)
        {
            HienLoi(ex);
        }
    }

    // ===== UPDATE =====
    private async void btnSua_Click(object? sender, EventArgs e)
    {
        if (dgvSinhVien.CurrentRow?.DataBoundItem is not SinhVienDTO svDangChon)
        {
            MessageBox.Show("Vui lòng chọn một dòng để sửa!");
            return;
        }

        if (!double.TryParse(txtDiem.Text, out double diemMoi))
        {
            MessageBox.Show("Điểm không hợp lệ!");
            return;
        }

        try
        {
            await _service.SuaAsync(svDangChon.Id, txtHoTen.Text, diemMoi);

            HienThongBao("Đã cập nhật thông tin!");
            await TaiDanhSach();
        }
        catch (Exception ex)
        {
            HienLoi(ex);
        }
    }

    // ===== DELETE =====
    private async void btnXoa_Click(object? sender, EventArgs e)
    {
        if (dgvSinhVien.CurrentRow?.DataBoundItem is not SinhVienDTO svDangChon)
        {
            MessageBox.Show("Vui lòng chọn một dòng để xóa!");
            return;
        }

        DialogResult ketQua = MessageBox.Show(
            $"Bạn có chắc muốn xóa \"{svDangChon.FullName}\"?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (ketQua != DialogResult.Yes) return;

        try
        {
            await _service.XoaAsync(svDangChon.Id);

            HienThongBao("Đã xóa sinh viên!");
            txtHoTen.Clear();
            txtDiem.Clear();
            await TaiDanhSach();
        }
        catch (Exception ex)
        {
            HienLoi(ex);
        }
    }

    // ===== Lọc sinh viên đạt (quy tắc "đạt" nằm ở BLL) =====
    private async void btnLocDat_Click(object? sender, EventArgs e)
    {
        try
        {
            List<SinhVienDTO> ds = await _service.LayDanhSachDatAsync();
            DoDuLieuLenLuoi(ds);
            HienThongBao($"Có {ds.Count} sinh viên đạt (điểm >= {SinhVienService.DiemDat}).");
        }
        catch (Exception ex)
        {
            HienLoi(ex);
        }
    }
}
