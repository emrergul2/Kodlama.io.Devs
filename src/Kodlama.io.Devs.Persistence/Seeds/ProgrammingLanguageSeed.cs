using System;
using Kodlama.io.Devs.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kodlama.io.Devs.Persistence.Seeds;

public class ProgrammingLanguageSeed : IEntityTypeConfiguration<ProgrammingLanguage>
{
    public void Configure(EntityTypeBuilder<ProgrammingLanguage> builder)
    {
        builder.HasData
        (
            new ProgrammingLanguage
            {
                Id = Guid.NewGuid(),
                Name = "C#",
                FirstReleaseDate = "08/10/2001"
            },
            new ProgrammingLanguage
            {
                Id = Guid.NewGuid(),
                Name = "Java",
                FirstReleaseDate = "23/01/1996"
            },
            new ProgrammingLanguage
            {
                Id = Guid.NewGuid(),
                Name = "Go",
                FirstReleaseDate = "10/11/2009"
            }
        );
    }
}