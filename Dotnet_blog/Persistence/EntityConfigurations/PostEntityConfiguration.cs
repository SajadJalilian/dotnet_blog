using Dotnet_blog.domain;

using Microsoft.EntityFrameworkCore;

namespace Dotnet_blog.Persistence.EntityConfigurations;

public sealed class PostEntityConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(q => q.Id);

        builder.Property(x => x.Title)
            .HasMaxLength(100);

        builder.Property(x => x.Title)
            .HasMaxLength(1000);
    }
}