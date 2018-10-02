namespace DiemThiHocSinhGioi.Models.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiemHsGioi")]
    public partial class DiemHsGioi
    {
        [StringLength(50)]
        public string STT { get; set; }

        [StringLength(50)]
        public string Mon { get; set; }

        [Key]
        [StringLength(50)]
        public string SBD { get; set; }

        [StringLength(50)]
        public string Phong { get; set; }

        [StringLength(50)]
        public string Ho { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string Lop { get; set; }

        [StringLength(200)]
        public string Truong { get; set; }

        [StringLength(50)]
        public string MaTruong { get; set; }

        [StringLength(50)]
        public string DiemV1 { get; set; }

        [StringLength(50)]
        public string DiemV2 { get; set; }

        [StringLength(50)]
        public string Tong { get; set; }

        [StringLength(50)]
        public string XepGiai { get; set; }

        [StringLength(4000)]
        public string GhiChu { get; set; }
    }
}
