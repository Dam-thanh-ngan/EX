namespace WebsiteBanHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietNhap")]
    public partial class ChiTietNhap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STT { get; set; }

        [Required]
        [StringLength(20)]
        public string MaPhieuNhap { get; set; }

        [Required]
        [StringLength(20)]
        public string MaHangHoa { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayNhap { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNCC { get; set; }
    }
}
