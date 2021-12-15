using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NguyenThiLuong118.Models
{
    [Table("NTL1118s")]
    public class NTL1118
    {
        [Key]
        [Display(Name = "Mã Sinh Viên")]
        [StringLength(20)]
        [Required]
        public string NTLId { get; set; }
        [Display(Name = "Tên Sinh Viên")]
        [StringLength(50)]
        [Required]
        public string NTLName {get; set;}
         [Display(Name = "Giới tính")]
         [Required]
        public bool NTLGender {get; set;}

    }
}