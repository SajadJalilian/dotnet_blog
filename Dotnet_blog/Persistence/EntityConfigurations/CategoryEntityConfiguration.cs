using Dotnet_blog.domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet_blog.Persistence.EntityConfigurations;

public sealed class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(q => q.Id);

        builder.Property(x => x.Title)
            .HasMaxLength(100);
    }
}