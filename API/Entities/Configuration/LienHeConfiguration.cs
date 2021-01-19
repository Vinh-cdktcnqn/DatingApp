using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Entities.Configuration
{
    class LienHeConfiguration : IEntityTypeConfiguration<LienHe>
    {
        public void Configure(EntityTypeBuilder<LienHe> builder)
        {
            builder.ToTable("LienHe");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.NoiDung).IsRequired().HasColumnType("ntext");
            builder.Property(x => x.HoTen).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(x => x.Email).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(x => x.SoDienThoai).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(x => x.FileDinhKem).IsRequired(false).HasColumnType("nvarchar(200)");
            builder.Property(x => x.DaLienHe).IsRequired().HasDefaultValue(false);

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
