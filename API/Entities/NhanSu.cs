using API.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Entities
{
    public partial class NhanSu : Auditable
    {
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
    }
}
