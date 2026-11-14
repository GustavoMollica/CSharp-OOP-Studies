namespace BlogPosts.Entities;

public class Comment
{
    public required string Text { get; set; }

    public override string ToString()
    {
        return Text;
    }
}
