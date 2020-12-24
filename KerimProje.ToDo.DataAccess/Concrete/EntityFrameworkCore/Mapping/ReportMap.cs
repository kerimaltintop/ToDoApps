using KerimProje.ToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KerimProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class ReportMap : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.Property(I => I.Definition).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Detail).HasColumnType("ntext");
            builder.HasOne(I => I.Task).WithMany(I => I.Reports).HasForeignKey(I => I.TaskId);
        }
    }
}
