using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Persistence.Repositories;

namespace Kodlama.io.Devs.Domain.Entities
{
    public class ProgrammingLanguage : Entity
    {
        public string? Name { get; set; }
        public string? FirstReleaseDate { get; set; }
        public ProgrammingLanguage()
        {
            Id = Guid.NewGuid();
        }
        public ProgrammingLanguage(string name, string firstReleaseDate)
        {
            Name = name;
            FirstReleaseDate = firstReleaseDate;
        }
    }
}
