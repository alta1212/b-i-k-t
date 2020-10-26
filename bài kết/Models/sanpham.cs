namespace bài_kết.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sanpham")]
    public partial class sanpham
    {
        [Key]
        [StringLength(50)]
        public string anh { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        public int? gia { get; set; }

        public int? giamoi { get; set; }

        [StringLength(200)]
        public string mota { get; set; }

        public int? star { get; set; }
    }
}
