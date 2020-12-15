using KerimProje.ToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KerimProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class WorkMap : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.Property(I => I.Name).HasMaxLength(200);
            builder.Property(I => I.Explanation).HasColumnType("ntext");
        }
    }
}
