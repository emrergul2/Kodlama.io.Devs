using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kodlama.io.Devs.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kodlama.io.Devs.Persistence.Contexts
{
    public class MsSqlQueryDbContext : DbContext
    {
        public MsSqlQueryDbContext(DbContextOptions<MsSqlQueryDbContext> options) : base(options)
        {

        }

        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}