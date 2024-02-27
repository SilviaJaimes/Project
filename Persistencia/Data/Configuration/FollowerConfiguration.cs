using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class FollowerConfiguration: IEntityTypeConfiguration<Follower>
{
    public void Configure(EntityTypeBuilder<Follower> builder)
    {
        builder.ToTable("follower");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.CreatedAt)
        .HasColumnName("createdAt")
        .HasColumnType("date")
        .IsRequired();

        builder.HasOne(d => d.Usuario)
        .WithMany(d => d.Followers)
        .HasForeignKey(d => d.IdUser);
    }
}