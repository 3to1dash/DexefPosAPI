using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EticketCustomerConfiguration : IEntityTypeConfiguration<EticketCustomer>
{


    public void Configure(EntityTypeBuilder<EticketCustomer> builder)
    {
        builder.HasNoKey();

        builder.ToView("ETicketCustomer");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Name)
            .HasMaxLength(400)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");
    }
}