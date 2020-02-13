namespace TestOData.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiThucAn")]
    public partial class LoaiThucAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiThucAn()
        {
            ChiTietThucAns = new HashSet<ChiTietThucAn>();
        }

        [StringLength(30)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoai { get; set; }

        [Required]
        [StringLength(250)]
        public string Anh { get; set; }

        [StringLength(100)]
        public string Link { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietThucAn> ChiTietThucAns { get; set; }
    }
}
