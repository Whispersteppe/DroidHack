using DroidHack.Repository.SqlServer.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidHack.Repository.SqlServer.ModelConfiguration;

public class AllianceConfiguration : IEntityTypeConfiguration<Alliance>
{
    public void Configure(EntityTypeBuilder<Alliance> builder)
    {
        builder.ToTable(nameof(Alliance));
        builder.HasKey(x => x.Id);
    }
}
