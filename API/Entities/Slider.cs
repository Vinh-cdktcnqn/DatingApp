using API.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Entities
{
    public partial class Slider: Auditable
    {
        public string UrlImage { get; set; }

        public string UrlSmallImage { get; set; }

        public string Link { get; set; }

        public int STT { get; set; }        
    }
}
