using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class LikeConfiguration: IEntityTypeConfiguration<Like>
{
    public void Configure(EntityTypeBuilder<Like> builder)
    {
        builder.ToTable("like");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.CreatedAt)
        .HasColumnName("createdAt")
        .HasColumnType("date")
        .IsRequired();

        builder.HasOne(d => d.Usuario)
        .WithMany(d => d.Likes)
        .HasForeignKey(d => d.IdUser);

        builder.HasOne(d => d.Post)
        .WithMany(d => d.Likes)
        .HasForeignKey(d => d.IdPost);
    }
}