using API.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class LienHeDto : Auditable
    {
        public string NoiDung { get; set; }

        public string HoTen { get; set; }

        public string Email { get; set; }

        public string SoDienThoai { get; set; }

        public string FileDinhKem { get; set; }

        public bool DaLienHe { get; set; }
    }

    public class LienHeForAction : AuditableDto
    {
        [Required(ErrorMessage = "NoiDung needs to be filled in")]
        public string NoiDung { get; set; }

        [Required(ErrorMessage = "HoTen needs to be filled in")]
        [MaxLength(50, ErrorMessage = "HoTen needs to be up to 50 characters")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Email needs to be filled in")]
        [MaxLength(50, ErrorMessage = "Email needs to be up to 50 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "SoDienThoai needs to be filled in")]
        public string SoDienThoai { get; set; }        

        public string FileDinhKem { get; set; }

        [Required(ErrorMessage = "DaLienHe needs to be filled in")]
        public bool DaLienHe { get; set; }   
    }
}
