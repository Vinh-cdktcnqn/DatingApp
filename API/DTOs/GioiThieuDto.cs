using API.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class GioiThieuDto : Auditable
    {
        public string TieuDe { get; set; }

        public string TieuDeLink { get; set; }

        public string TomTat { get; set; }

        public string NoiDung { get; set; }

        public string Video { get; set; }
    }

    public class GioiThieuForAction : AuditableDto
    {     
        [Required(ErrorMessage = "TieuDe needs to be filled in")]
        [MaxLength(200, ErrorMessage = "TieuDe needs to be up to 200 characters")]
        public string TieuDe { get; set; }

        [Required(ErrorMessage = "TieuDeLink needs to be filled in")]
        [MaxLength(200, ErrorMessage = "TieuDeLink needs to be up to 200 characters")]
        public string TieuDeLink { get; set; }

        public string TomTat { get; set; }

        [Required(ErrorMessage = "NoiDung needs to be filled in")]
        public string NoiDung { get; set; }

        public string Video { get; set; }   
    }
}
