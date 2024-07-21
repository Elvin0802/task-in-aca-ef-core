using AppDbContext db = new();

User u1 = new();
u1.Login = "u1";
u1.Birtday = DateTime.Now.AddYears(-25);
u1.Gender = false;
u1.Posts = new List<Post>();
u1.IsOpen = true;
u1.Pswd = "u1u1u1";

//-----------------------------------

User u2 = new();
u2.Login = "u2";
u2.Birtday = DateTime.Now.AddYears(-32);
u2.Gender = true;
u2.Posts = new List<Post>();
u2.IsOpen = false;
u2.Pswd = "u2u2u2";

Post p1 = new();
p1.Date = DateTime.Now;
p1.Text = "new post 11111";
p1.ImagePath = @"D:\";
p1.Tags = new List<Tag>();

//-----------------------------------

Post p2 = new();
p2.Date = DateTime.Now;
p2.Text = "new post 22222";
p2.ImagePath = @"D:\";
p2.Tags = new List<Tag>();

u1.Posts.Add(p1);
u2.Posts.Add(p2);

Tag t1 = new();
Tag t2 = new();

t1.TagText = "salamasm 111";
t2.TagText = "salamasm 222";

p1.Tags.Add(t1);
p2.Tags.Add(t2);

db.Tags.AddRange(t1,t2);
db.Posts.AddRange(p1,p2);
db.Users.AddRange(u1,u2);
db.SaveChanges();
