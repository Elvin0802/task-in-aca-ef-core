public class Post
{
	public int Id { get; set; }
	public string? Text { get; set; }
	public string ImagePath { get; set; }
	public DateTime Date { get; set; } = DateTime.Now;

    public Post()
    {

    }

	public List<Tag>? Tags { get; set; }

}
