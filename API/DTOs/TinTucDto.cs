using API.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class TinTucDto : Auditable
    {
        public string TieuDe { get; set; }

        public string TieuDeLink { get; set; }

        public bool HienThiTieuDe { get; set; }

        public string TomTat { get; set; }

        public bool HienThiTomTat { get; set; }

        public string NoiDung { get; set; }

        public string HinhAnh { get; set; }

        public bool HienThiHinhAnh { get; set; }

        public int LuotXem { get; set; }

        public bool TinNong { get; set; }

        public string FileDinhKem { get; set; }

        public bool HienThiFileDinhKem { get; set; }
    }

    public class TinTucForAction : AuditableDto
    {     
        [Required(ErrorMessage = "TieuDe needs to be filled in")]
        [MaxLength(200, ErrorMessage = "TieuDe needs to be up to 200 characters")]
        public string TieuDe { get; set; }

        [Required(ErrorMessage = "TieuDeLink needs to be filled in")]
        [MaxLength(200, ErrorMessage = "TieuDeLink needs to be up to 200 characters")]
        public string TieuDeLink { get; set; }

        public string TomTat { get; set; }

        [Required(ErrorMessage = "HienThiTomTat needs to be filled in")]
        public bool HienThiTomTat { get; set; }

        [Required(ErrorMessage = "NoiDung needs to be filled in")]
        public string NoiDung { get; set; }

        [Required(ErrorMessage = "HinhAnh needs to be filled in")]
        public string HinhAnh { get; set; }

        [Required(ErrorMessage = "HienThiHinhAnh needs to be filled in")]
        public bool HienThiHinhAnh { get; set; }

        [Required(ErrorMessage = "LuotXem needs to be filled in")]
        public int LuotXem { get; set; }

        [Required(ErrorMessage = "TinNong needs to be filled in")]
        public bool TinNong { get; set; }

        public string FileDinhKem { get; set; }

        [Required(ErrorMessage = "HienThiFileDinhKem needs to be filled in")]
        public bool HienThiFileDinhKem { get; set; }
    }
}
