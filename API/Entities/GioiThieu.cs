using API.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace API.Entities
{
    public partial class GioiThieu : Auditable
    {
        public string TieuDe { get; set; }

        public string TieuDeLink { get; set; }

        public string TomTat { get; set; }

        public string NoiDung { get; set; }

        public string Video { get; set; }
    }
}
