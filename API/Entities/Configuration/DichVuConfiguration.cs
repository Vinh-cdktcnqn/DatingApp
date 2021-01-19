using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Entities.Configuration
{
    class DichVuConfiguration : IEntityTypeConfiguration<DichVu>
    {
        public void Configure(EntityTypeBuilder<DichVu> builder)
        {
            builder.ToTable("DichVu");
            builder.HasKey(x => x.ID);            
            builder.Property(x => x.TenDichVu).IsRequired().HasColumnType("nvarchar(200)");
            builder.Property(x => x.TenDichVuLink).IsRequired().HasColumnType("varchar(200)");
            builder.Property(x => x.TomTat).IsRequired(false).HasColumnType("nvarchar(500)");
            builder.Property(x => x.HienThiTomTat).IsRequired(true).HasDefaultValue(true);
            builder.Property(x => x.NoiDung).IsRequired().HasColumnType("ntext");
            builder.Property(x => x.HinhAnh).IsRequired().HasColumnType("nvarchar(200)");
            builder.Property(x => x.HienThiHinhAnh).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.STT).IsRequired().HasDefaultValue(1);

            builder.Property(x => x.KichHoat).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.NgayTao).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(x => x.NguoiTao).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(x => x.NgaySua).IsRequired(false);
            builder.Property(x => x.NguoiSua).IsRequired(false).HasColumnType("nvarchar(50)");
            builder.Property(x => x.DaXoa).IsRequired(false);
            builder.Property(x => x.NgayXoa).IsRequired(false);
            builder.Property(x => x.NguoiXoa).IsRequired(false).HasColumnType("nvarchar(50)");
        }
    }
}
