using Dotnet_blog.domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet_blog.Persistence.EntityConfigurations;

public sealed class UserEntityConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(q => q.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(100);

        builder.Property(x => x.LastName)
            .HasMaxLength(100);

        builder.Property(x => x.Email)
            .HasMaxLength(100);

        builder.Property(x => x.Phone)
            .HasMaxLength(20);
    }
}