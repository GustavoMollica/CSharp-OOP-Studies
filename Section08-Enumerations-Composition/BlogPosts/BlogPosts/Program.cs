using BlogPosts.Entities;

string[][] commentsByPost =
{
    new[] { "Parabensss pelo seu momento.", "Incrivell momentooo." },
    new[] { "uhulll, parabensssss.", "Que a Forca esteja com voce." }
};

var posts = new List<Post>();

for (int i = 0; i < commentsByPost.Length; i++)
{
    Console.WriteLine($"Digite o titulo do {i + 1}° post:");
    string? title = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(title))
    {
        Console.WriteLine("Valor invalido. Digite um titulo valido.");
        title = Console.ReadLine();
    }

    Console.WriteLine($"Digite a descricao do {i + 1}° post:");
    string? content = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(content))
    {
        Console.WriteLine("Valor invalido. Digite uma descricao valida.");
        content = Console.ReadLine();
    }

    var post = new Post
    {
        Moment = DateTime.Now,
        Title = title,
        Content = content,
    };

    foreach (var text in commentsByPost[i])
    {
        post.AddComment(new Comment { Text = text });
    }

    posts.Add(post);
}

Console.WriteLine("\n\nPosts publicados:");
foreach (var post in posts)
{
    Console.WriteLine(post);
}
