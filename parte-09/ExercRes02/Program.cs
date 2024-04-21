

using ExercRes02.Entities;

Comment c1 = new Comment("Have a nice trip");
Comment c2 = new Comment("That's awesome");

Post p1 = new Post(
	DateTime.Parse("21/06/2018 13:05:44"),
	"Traveling to New Zealand",
	"I'm going to visit this wonderful country",
	12);

Post p2 = new Post(
	DateTime.Parse("28/07/2018 23:14:19"),
	"Goodnight",
	"See you tomorrow",
	5);

p1.AddComment(c1);
p1.AddComment(c2);


