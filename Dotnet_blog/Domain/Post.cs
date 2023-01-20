using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_blog.domain;

public sealed class Post : BaseEntity
{
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;

    // Navigation
    public User Author { get; set; } = null!;
    public IEnumerable<Category> Categories { get; set; } = null!;
}