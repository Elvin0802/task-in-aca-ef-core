public class User
{
    public User()
    {
        
    }


    public int Id { get; set; }
	public string Login { get; set; }
	public string Pswd { get; set; }
	public bool IsOpen { get; set; } = true;
	public bool Gender { get; set; } = true;
	public DateTime? Birtday { get; set; }

	public List<Post>? Posts { get; set; }

	public override string ToString()
	{
		return $@"
		{Login} / {Gender} / {Birtday.Value.ToShortDateString()}
		
		
		";
	}

}
