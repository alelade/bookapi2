namespace Book.Data;

using Shared.Data;

public class Book:EntityBase
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublishYear { get; set; }
}