using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class AuditableDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "KichHoat needs to be filled in")]
        public bool KichHoat { get; set; }

        [Required(ErrorMessage = "NgayTao needs to be filled in")]
        public DateTime? NgayTao { get; set; }

        [Required(ErrorMessage = "NguoiTao needs to be filled in")]
        public string NguoiTao { get; set; }

        public DateTime? NgaySua { get; set; }

        public string NguoiSua { get; set; }

        public bool? DaXoa { get; set; }

        public DateTime? NgayXoa { get; set; }

        public string NguoiXoa { get; set; }
    }
}
