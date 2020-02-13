namespace TestOData.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDonDatHang")]
    public partial class ChiTietDonDatHang
    {
        public int ID { get; set; }

        public int IDDonDatHang { get; set; }

        [StringLength(30)]
        public string IDThucAn { get; set; }

        public int Gia { get; set; }

        public int SoLuong { get; set; }

        public virtual DonDatHang DonDatHang { get; set; }

        public virtual ChiTietThucAn ChiTietThucAn { get; set; }
    }
}
