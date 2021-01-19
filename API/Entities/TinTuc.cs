using API.Entities.Abstract;

namespace API.Entities
{
    public class TinTuc : Auditable
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
}
