using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class PostConfiguration: IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable("post");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.UrlImage)
        .HasColumnName("urlImage")
        .HasColumnType("varchar")
        .HasMaxLength(400)
        .IsRequired();

        builder.Property(p => p.Caption)
        .HasColumnName("caption")
        .HasColumnType("varchar")
        .HasMaxLength(350)
        .IsRequired();

        builder.Property(p => p.CreatedAt)
        .HasColumnName("createdAt")
        .HasColumnType("date")
        .IsRequired();

        builder.HasOne(d => d.Usuario)
        .WithMany(d => d.Posts)
        .HasForeignKey(d => d.IdUser);
    }
}