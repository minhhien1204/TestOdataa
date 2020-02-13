namespace TestOData.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietThucAn")]
    public partial class ChiTietThucAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiTietThucAn()
        {
            ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();
        }

        [StringLength(30)]
        public string ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TenThucAn { get; set; }

        [StringLength(250)]
        public string AnhChinh { get; set; }

        [StringLength(250)]
        public string Anh2 { get; set; }

        [StringLength(250)]
        public string Anh3 { get; set; }

        [StringLength(250)]
        public string Anh4 { get; set; }

        [Required]
        [StringLength(1000)]
        public string MoTaChiTiet { get; set; }

        public int Gia { get; set; }

        public int LuotThich { get; set; }

        public int LuotDanhGia5Sao { get; set; }

        public int LuotDanhGia4Sao { get; set; }

        public int LuotDanhGia3Sao { get; set; }

        public int LuotDanhGia2Sao { get; set; }

        public int LuotDanhGia1Sao { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayNhap { get; set; }

        public bool TrangThai { get; set; }

        [Required]
        [StringLength(30)]
        public string IDLoai { get; set; }

        public int? GiaKhuyenMai { get; set; }

        [Required]
        [StringLength(250)]
        public string MetaTitle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }

        public virtual LoaiThucAn LoaiThucAn { get; set; }
    }
}
