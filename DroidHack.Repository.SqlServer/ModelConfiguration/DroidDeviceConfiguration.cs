using DroidHack.Repository.SqlServer.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DroidHack.Repository.SqlServer.ModelConfiguration;

public class DroidDeviceConfiguration : IEntityTypeConfiguration<DroidDevice>
{
    public void Configure(EntityTypeBuilder<DroidDevice> builder)
    {
        builder.ToTable(nameof(DroidDevice));
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Device)
            .WithMany(x=>x.DroidDevices)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
