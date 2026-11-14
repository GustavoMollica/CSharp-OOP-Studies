using System.Globalization;
using System.Text;

namespace BlogPosts.Entities;

public class Post
{
    private readonly List<Comment> _comments = new();
    public int Likes { get; private set; } = Random.Shared.Next(1, 1001);
    public DateTime Moment { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public IReadOnlyList<Comment> Comments => _comments;

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void RemoveComment(Comment comment)
    {
        _comments.Remove(comment);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(Title);
        sb.Append(Likes);
        sb.Append(" curtidas - ");
        sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture));
        sb.AppendLine(Content);
        sb.AppendLine("Comentarios:");
        foreach (var comment in _comments)
        {
            sb.AppendLine(comment.Text);
        }
        return sb.ToString();
    }
}
