using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NguyenThiLuong118.Models
{
    [Table("UniversityNTL118s")]
    public class UniversityNTL118
    {
        [Key]
        [Display(Name = "Mã Trường Đại Học")]
        [StringLength(20)]
        [Required]

        public string UniversityId { get; set; }
        [Display(Name = "Tên Trường Đại Học")]
        [StringLength(50)]
        public string UniversityName {get; set;}

    }
}