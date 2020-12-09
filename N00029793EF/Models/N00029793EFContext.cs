using Microsoft.EntityFrameworkCore;
using N00029793EF.Models.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793EF.Models
{
    public class N00029793EFContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public DbSet<Tag> Tages { get; set; }

        public DbSet<TagNote> TagNotes { get; set; }

        public N00029793EFContext(DbContextOptions<N00029793EFContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new NoteMap());

            modelBuilder.ApplyConfiguration(new TagMap());

            modelBuilder.ApplyConfiguration(new TagNoteMap());


        }
    }
}
