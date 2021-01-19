using API.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class DichVuDto : Auditable
    {
        public string TenDichVu { get; set; }

        public string TenDichVuLink { get; set; }

        public string TomTat { get; set; }

        public bool HienThiTomTat { get; set; }

        public string NoiDung { get; set; }

        public string HinhAnh { get; set; }

        public bool HienThiHinhAnh { get; set; }

        public int STT { get; set; }
    }

    public class DichVuForAction : AuditableDto
    {     
        [Required(ErrorMessage = "TenDichVu needs to be filled in")]
        [MaxLength(200, ErrorMessage = "TenDichVu needs to be up to 200 characters")]
        public string TenDichVu { get; set; }

        [Required(ErrorMessage = "TenDichVuLink needs to be filled in")]
        [MaxLength(200, ErrorMessage = "TenDichVuLink needs to be up to 200 characters")]
        public string TenDichVuLink { get; set; }

        public string TomTat { get; set; }

        [Required(ErrorMessage = "HienThiTomTat needs to be filled in")]
        public bool HienThiTomTat { get; set; }

        [Required(ErrorMessage = "NoiDung needs to be filled in")]
        public string NoiDung { get; set; }

        [Required(ErrorMessage = "HinhAnh needs to be filled in")]
        public string HinhAnh { get; set; }

        [Required(ErrorMessage = "HienThiHinhAnh needs to be filled in")]
        public bool HienThiHinhAnh { get; set; }

        [Required(ErrorMessage = "STT needs to be filled in")]
        public int STT { get; set; }
    }
}
