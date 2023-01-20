using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_blog.domain;

public sealed class Comment : BaseEntity
{
    public string Name { get; set; }
    public string Content { get; set; }
    public string Email { get; set; }

    // Navigation
    public Post Post { get; set; }
    public Comment Parent { get; set; }
}