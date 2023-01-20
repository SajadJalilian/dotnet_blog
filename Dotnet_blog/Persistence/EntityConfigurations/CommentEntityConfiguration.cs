using Dotnet_blog.domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet_blog.Persistence.EntityConfigurations;

public sealed class CommentEntityConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(q => q.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(100);

        builder.Property(x => x.Content)
            .HasMaxLength(500);
    }
}