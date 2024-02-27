using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class CommentConfiguration: IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.ToTable("comment");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .IsRequired();

        builder.Property(p => p.CommentText)
        .HasColumnName("commentText")
        .HasColumnType("varchar")
        .HasMaxLength(350)
        .IsRequired();

        builder.Property(p => p.CreatedAt)
        .HasColumnName("createdAt")
        .HasColumnType("date")
        .IsRequired();

        builder.HasOne(d => d.Post)
        .WithMany(d => d.Comments)
        .HasForeignKey(d => d.IdPost);

        builder.HasOne(d => d.Usuario)
        .WithMany(d => d.Comments)
        .HasForeignKey(d => d.IdUser);
    }
}