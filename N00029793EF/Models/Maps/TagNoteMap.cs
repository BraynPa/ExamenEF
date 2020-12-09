using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793EF.Models.Maps
{
    public class TagNoteMap : IEntityTypeConfiguration<TagNote>
    {
        public void Configure(EntityTypeBuilder<TagNote> builder)
        {
            builder.ToTable("TagNote");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.Tag).
                WithMany().
                HasForeignKey(o => o.IdTag);
            builder.HasOne(o => o.note).
                WithMany().
                HasForeignKey(o => o.IdNote);

        }
    }
}
