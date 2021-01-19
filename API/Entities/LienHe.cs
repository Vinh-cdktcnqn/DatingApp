using API.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace API.Entities
{
    public partial class LienHe : Auditable
    {
        public string NoiDung { get; set; }

        public string HoTen { get; set; }

        public string Email { get; set; }

        public string SoDienThoai { get; set; }

        public string FileDinhKem { get; set; }

        public bool DaLienHe { get; set; }
    }
}
