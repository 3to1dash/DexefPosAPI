using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EticketUserConfiguration : IEntityTypeConfiguration<EticketUser>
{


    public void Configure(EntityTypeBuilder<EticketUser> builder)
    {
        builder.HasNoKey();

        builder.ToView("ETicketUser");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.ProvidorId).HasColumnName("ProvidorID");

        builder.Property(e => e.ProvidorName).HasMaxLength(50);

        builder.Property(e => e.UserName).HasMaxLength(50);

        builder.Property(e => e.WorkInCompany).HasMaxLength(400);
    }
}