using Kodlama.io.Devs.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kodlama.io.Devs.Persistence.Configurations;

public class ProgrammingLanguageConfigurations : IEntityTypeConfiguration<ProgrammingLanguage>
{
    public void Configure(EntityTypeBuilder<ProgrammingLanguage> builder)
    {
        builder.HasKey(pl => pl.Id);
        builder.Property(pl => pl.Name).IsRequired();
        builder.Property(pl => pl.Name).HasMaxLength(100);
    }
}
