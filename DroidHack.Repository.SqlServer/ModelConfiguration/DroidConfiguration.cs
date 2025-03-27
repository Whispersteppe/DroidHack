using DroidHack.Repository.SqlServer.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DroidHack.Repository.SqlServer.ModelConfiguration;

public class DroidConfiguration : IEntityTypeConfiguration<Droid>
{
    public void Configure(EntityTypeBuilder<Droid> builder)
    {
        builder.ToTable(nameof(Droid));
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.User)
            .WithMany(x => x.Droids)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
