using DroidHack.Repository.SqlServer.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DroidHack.Repository.SqlServer.ModelConfiguration;

public class AllianceMemberConfiguration : IEntityTypeConfiguration<AllianceMember>
{
    public void Configure(EntityTypeBuilder<AllianceMember> builder)
    {
        builder.ToTable(nameof(AllianceMember));
        builder.HasKey(x => x.Id);


        builder.HasOne(x => x.Alliance)
            .WithMany(x => x.Members)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x=>x.Member)
            .WithMany(x=>x.Alliances)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
