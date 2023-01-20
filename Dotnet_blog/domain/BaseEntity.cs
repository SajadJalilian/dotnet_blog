namespace Dotnet_blog.domain;

public interface IEntity
{
    int Id { get; set; }
}

public class BaseEntity : IEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}