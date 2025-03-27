using DroidHack.Repository.SqlServer.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DroidHack.Repository.SqlServer.ModelConfiguration;

public class DroidHackUserConfiguration : IEntityTypeConfiguration<DroidHackUser>
{
    public void Configure(EntityTypeBuilder<DroidHackUser> builder)
    {
        builder.ToTable(nameof(DroidHackUser));
        builder.HasKey(x => x.Id);
    }
}
