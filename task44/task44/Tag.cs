﻿public class Tag
{

	public int Id { get; set; }
	public string TagText { get; set; }

	public List<Post>? Tags { get; set; }

}
