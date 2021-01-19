using API.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class NhanSuDto : Auditable
    {
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
    }

    public class NhanSuForAction : AuditableDto
    {
        [Required(ErrorMessage = "HoTen needs to be filled in")]
        [MaxLength(50, ErrorMessage = "HoTen needs to be up to 50 characters")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "ChucVu needs to be filled in")]
        [MaxLength(100, ErrorMessage = "ChucVu needs to be up to 100 characters")]
        public string ChucVu { get; set; }

        [Required(ErrorMessage = "SoDienThoai needs to be filled in")]
        public string SoDienThoai { get; set; }  

        [Required(ErrorMessage = "Email needs to be filled in")]
        [MaxLength(50, ErrorMessage = "Email needs to be up to 50 characters")]
        public string Email { get; set; }   
    }
}
