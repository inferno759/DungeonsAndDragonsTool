using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using CharacterCreation;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Repository
{
    class DnDcontext : DbContext
    {
        public DnDcontext(DbContextOptions<DnDcontext> options) : base(options) { }

        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Race> Races { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Character>(entity =>
            {
                entity.ToTable("Character", "DnDHalper");

                entity.Property(e => e.characterLevel)
                    .IsRequired();

            });
        }


    }
}
