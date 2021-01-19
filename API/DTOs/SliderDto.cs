using API.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class SliderDto : Auditable
    {
        public string UrlImage { get; set; }

        public string UrlSmallImage { get; set; }

        public string Link { get; set; }

        public int STT { get; set; }
    }

    public class SliderForAction : AuditableDto
    {
        [Required(ErrorMessage = "UrlImage needs to be filled in")]
        [MaxLength(200, ErrorMessage = "UrlImage needs to be up to 200 characters")]
        public string UrlImage { get; set; }

        [Required(ErrorMessage = "UrlSmallImage needs to be filled in")]
        [MaxLength(200, ErrorMessage = "UrlSmallImage needs to be up to 200 characters")]
        public string UrlSmallImage { get; set; }

        [Required(ErrorMessage = "Link needs to be filled in")]
        [MaxLength(200, ErrorMessage = "Link needs to be up to 200 characters")]
        public string Link { get; set; }  

        [Required(ErrorMessage = "STT needs to be filled in")]
        public int STT { get; set; }   
    }
}
