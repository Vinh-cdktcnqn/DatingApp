using System;

namespace API.Entities.Abstract
{
    public partial class Auditable
    {
        public int ID { get; set; }

        public bool KichHoat { get; set; }

        public DateTime? NgayTao { get; set; }

        public string NguoiTao { get; set; }

        public DateTime? NgaySua { get; set; }

        public string NguoiSua { get; set; }

        public bool? DaXoa { get; set; }

        public DateTime? NgayXoa { get; set; }

        public string NguoiXoa { get; set; }
    }
}
