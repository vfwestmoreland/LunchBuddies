using LunchBuddies;

LunchBuddy Buddy = new("Mike", "Closky");
LunchBuddy buddy1 = new("Nick", "Stewart");
LunchBuddy buddy2 = new("Sarah", "Maginnis");
LunchBuddy buddy3 = new("Wes", "Westmoreland");

//Buddy.Eat("Chicken Nuggets");

List<LunchBuddy> BuddyList = new()
{
    buddy1, buddy2, buddy3
};

Buddy.Eat("Chicken Nuggets", BuddyList);

Console.ReadLine();