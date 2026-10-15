namespace QuanLySinhVien.UI;

partial class Form1
{
    private System.ComponentModel.IContainer components = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblTieuDe = new Label();
        lblHoTen = new Label();
        txtHoTen = new TextBox();
        lblDiem = new Label();
        txtDiem = new TextBox();
        btnThem = new Button();
        btnSua = new Button();
        btnXoa = new Button();
        btnTaiLai = new Button();
        btnLocDat = new Button();
        dgvSinhVien = new DataGridView();
        lblTrangThai = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
        SuspendLayout();
        //
        // lblTieuDe
        //
        lblTieuDe.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblTieuDe.Location = new Point(12, 9);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new Size(616, 32);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "QUẢN LÝ SINH VIÊN - MÔ HÌNH 3 LỚP (DAL - BLL - UI)";
        lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
        //
        // lblHoTen
        //
        lblHoTen.AutoSize = true;
        lblHoTen.Location = new Point(12, 56);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new Size(48, 15);
        lblHoTen.TabIndex = 1;
        lblHoTen.Text = "Họ tên:";
        //
        // txtHoTen
        //
        txtHoTen.Location = new Point(70, 52);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new Size(250, 23);
        txtHoTen.TabIndex = 2;
        //
        // lblDiem
        //
        lblDiem.AutoSize = true;
        lblDiem.Location = new Point(340, 56);
        lblDiem.Name = "lblDiem";
        lblDiem.Size = new Size(38, 15);
        lblDiem.TabIndex = 3;
        lblDiem.Text = "Điểm:";
        //
        // txtDiem
        //
        txtDiem.Location = new Point(385, 52);
        txtDiem.Name = "txtDiem";
        txtDiem.Size = new Size(70, 23);
        txtDiem.TabIndex = 4;
        //
        // btnThem
        //
        btnThem.Location = new Point(12, 90);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(85, 30);
        btnThem.TabIndex = 5;
        btnThem.Text = "➕ Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += btnThem_Click;
        //
        // btnSua
        //
        btnSua.Location = new Point(103, 90);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(85, 30);
        btnSua.TabIndex = 6;
        btnSua.Text = "✏ Sửa";
        btnSua.UseVisualStyleBackColor = true;
        btnSua.Click += btnSua_Click;
        //
        // btnXoa
        //
        btnXoa.Location = new Point(194, 90);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(85, 30);
        btnXoa.TabIndex = 7;
        btnXoa.Text = "🗑 Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += btnXoa_Click;
        //
        // btnTaiLai
        //
        btnTaiLai.Location = new Point(285, 90);
        btnTaiLai.Name = "btnTaiLai";
        btnTaiLai.Size = new Size(110, 30);
        btnTaiLai.TabIndex = 8;
        btnTaiLai.Text = "🔄 Tải lại danh sách";
        btnTaiLai.UseVisualStyleBackColor = true;
        btnTaiLai.Click += btnTaiLai_Click;
        //
        // btnLocDat
        //
        btnLocDat.Location = new Point(401, 90);
        btnLocDat.Name = "btnLocDat";
        btnLocDat.Size = new Size(140, 30);
        btnLocDat.TabIndex = 9;
        btnLocDat.Text = "Lọc SV đạt";
        btnLocDat.UseVisualStyleBackColor = true;
        btnLocDat.Click += btnLocDat_Click;
        //
        // dgvSinhVien
        //
        dgvSinhVien.AllowUserToAddRows = false;
        dgvSinhVien.AllowUserToDeleteRows = false;
        dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSinhVien.Location = new Point(12, 135);
        dgvSinhVien.MultiSelect = false;
        dgvSinhVien.Name = "dgvSinhVien";
        dgvSinhVien.ReadOnly = true;
        dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSinhVien.Size = new Size(616, 230);
        dgvSinhVien.TabIndex = 10;
        dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
        //
        // lblTrangThai
        //
        lblTrangThai.Location = new Point(12, 375);
        lblTrangThai.Name = "lblTrangThai";
        lblTrangThai.Size = new Size(616, 23);
        lblTrangThai.TabIndex = 11;
        lblTrangThai.Text = "Sẵn sàng.";
        //
        // Form1
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(640, 410);
        Controls.Add(lblTieuDe);
        Controls.Add(lblHoTen);
        Controls.Add(txtHoTen);
        Controls.Add(lblDiem);
        Controls.Add(txtDiem);
        Controls.Add(btnThem);
        Controls.Add(btnSua);
        Controls.Add(btnXoa);
        Controls.Add(btnTaiLai);
        Controls.Add(btnLocDat);
        Controls.Add(dgvSinhVien);
        Controls.Add(lblTrangThai);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản lý sinh viên - Mô hình 3 lớp";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTieuDe;
    private Label lblHoTen;
    private TextBox txtHoTen;
    private Label lblDiem;
    private TextBox txtDiem;
    private Button btnThem;
    private Button btnSua;
    private Button btnXoa;
    private Button btnTaiLai;
    private Button btnLocDat;
    private DataGridView dgvSinhVien;
    private Label lblTrangThai;
}
