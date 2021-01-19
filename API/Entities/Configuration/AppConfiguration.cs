using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Entities.Configuration
{
    public class AppConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfig");
            builder.HasKey(x => x.Key);
            builder.Property(x => x.Value).IsRequired().HasColumnType("nvarchar(200)");
            builder.Property(x => x.Key).HasColumnType("nvarchar(200)");
        }
    }
}
