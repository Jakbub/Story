string choiceone = "";
string choicetwo = "";
string choicethree = "";

Console.WriteLine("Prehistoric Time Machine");
Thread.Sleep(5000);
Console.Clear();

Console.WriteLine("You’ve built a time machine and traveled back to the prehistoric era!");
Thread.Sleep(3000);

Console.Clear();

Console.WriteLine("Dinosaurs roam the land. You need to survive...");
Thread.Sleep(3000);

Console.Clear();

Console.WriteLine("Do you want to explore the JUNGLE or head towards the MOUNTAINS?");
choiceone = Console.ReadLine();
choiceone = choiceone.ToLower();
Thread.Sleep(500);

if (choiceone == "jungle")
{
    Console.WriteLine("You walk into the jungle. It’s dark and filled with strange noises");
    Thread.Sleep(3000);
    Console.WriteLine("Do you CLIMB a tree to scout or continue to WALK forward?");
    Thread.Sleep(3000);
    choicetwo = Console.ReadLine();
    choicetwo = choicetwo.ToLower();
}


if (choicetwo == "climb")
{
    Console.WriteLine("You climb up a tree and spot a T-Rex nearby.");
    Console.WriteLine("You stay hidden until it leaves. You survive!");
}
else if (choicetwo == "walk")
{
    Console.WriteLine("You walk deeper into the jungle and get ambushed by raptors!");
    Console.WriteLine("You are quickly torn apart.");
}

if (choiceone == "mountains")
{
    Console.WriteLine("You head towards the mountains. The climb is steep and dangerous.");
    Thread.Sleep(3000);
    Console.WriteLine("Suddenly the ground beneath you crumbles!");
    Thread.Sleep(3000);
    Console.WriteLine("You fall into a ravine and don’t survive.");
}

        Console.WriteLine();
        Console.WriteLine("Press ENTER to exit.");
        Console.ReadLine();