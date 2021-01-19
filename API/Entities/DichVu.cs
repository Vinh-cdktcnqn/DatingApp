using API.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Entities
{
    public class DichVu : Auditable
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
}
