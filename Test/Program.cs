using GameStructures;

Console.Title = "Game Structures Test App";
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Testing GameStructures.PriorityQueue...");

PriorityQueue<string> nameQueue = new PriorityQueue<string>();

nameQueue.Enqueue("Very Low", 0);
nameQueue.Enqueue("Very High", 10);
nameQueue.Enqueue("Medium", 7);
nameQueue.Enqueue("High", 9);
nameQueue.Enqueue("Low", 3);


Console.WriteLine($"{Environment.NewLine}Dequeue using while Peek is not null:{Environment.NewLine}");
Console.ForegroundColor = ConsoleColor.DarkGray;

while (nameQueue.Peek() is not null)
{
    Console.WriteLine(nameQueue.Dequeue());
}

nameQueue.Enqueue("Very Low", 0);
nameQueue.Enqueue("Very High", 10);
nameQueue.Enqueue("Medium", 7);
nameQueue.Enqueue("High", 9);
nameQueue.Enqueue("Low", 3);

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"{Environment.NewLine}Dequeue using while reverse for:{Environment.NewLine}");
Console.ForegroundColor = ConsoleColor.DarkGray;

for (var i = nameQueue.Count; i > 0; i--)
{
    Console.WriteLine(nameQueue.Dequeue());
}

Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{Environment.NewLine}Press any key to continue...");
Console.ReadKey();