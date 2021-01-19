using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Entities.Configuration
{
    class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.ToTable("Slider");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.UrlImage).IsRequired().HasColumnType("nvarchar(200)");
            builder.Property(x => x.UrlSmallImage).IsRequired().HasColumnType("nvarchar(200)");
            builder.Property(x => x.Link).IsRequired().HasColumnType("nvarchar(200)");
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
