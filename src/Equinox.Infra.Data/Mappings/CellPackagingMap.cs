using Equinox.Domain.Models.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equinox.Infra.Data.Mappings
{
    public class CellPackagingMap : IEntityTypeConfiguration<CellPackaging>
    {
        public void Configure(EntityTypeBuilder<CellPackaging> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.BatchNumber)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.CellCode)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.PackageType)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Quantity)
                .IsRequired();

            builder.Property(c => c.OperatorId)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.PackageDate)
                .IsRequired();

            builder.Property(c => c.Status)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
} 