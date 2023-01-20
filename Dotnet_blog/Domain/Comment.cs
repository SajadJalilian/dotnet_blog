namespace Dotnet_blog.domain;

public sealed class Comment : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string Email { get; set; } = null!;

    // Navigation
    public Post Post { get; set; } = null!;
    public Comment Parent { get; set; } = null!;
}