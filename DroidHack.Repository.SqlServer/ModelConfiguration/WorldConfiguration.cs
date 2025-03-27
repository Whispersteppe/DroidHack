using DroidHack.Repository.SqlServer.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DroidHack.Repository.SqlServer.ModelConfiguration;

public class WorldConfiguration : IEntityTypeConfiguration<World>
{
    public void Configure(EntityTypeBuilder<World> builder)
    {
        builder.ToTable(nameof(World));
        builder.HasKey(x => x.Id);
    }
}
