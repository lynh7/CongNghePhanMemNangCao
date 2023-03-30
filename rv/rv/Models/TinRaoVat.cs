using System;
using System.Collections.Generic;

namespace rv.Models;

public partial class TinRaoVat
{
    public int MaTin { get; set; }

    public int? MaTrangThai { get; set; }

    public int? MaTinhTrang { get; set; }

    public int? MaLoaiTin { get; set; }

    public int? MaHinhThuc { get; set; }

    public int? MaNguoiDung { get; set; }

    public string? TieuDe { get; set; }

    public string? HinhAnh { get; set; }

    public string? NoiDung { get; set; }

    public DateTime? NgayGioDang { get; set; }

    public double? GiaTien { get; set; }

    public string? DiaChi { get; set; }

    public DateTime? NgayHetHan { get; set; }

    public string? MaThanhPho { get; set; }
}
