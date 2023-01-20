using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_blog.domain;

public sealed class Post : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
}