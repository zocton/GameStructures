using GameStructures;

Console.Title = "Game Structures Test App";
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Testing GameStructures.PriorityQueue...");

PriorityQueue<string> priorityQueue = new PriorityQueue<string>();

priorityQueue.Enqueue("Hello", 4);
priorityQueue.Enqueue($"PriorityQueue.{Environment.NewLine}", 1);
priorityQueue.Enqueue(" This is a ", 2);
priorityQueue.Enqueue(" world!", 3);


Console.WriteLine($"{Environment.NewLine}Dequeue using while Peek is not null:");
Console.ForegroundColor = ConsoleColor.DarkGray;

while (priorityQueue.Peek() is not null)
{
    Console.Write(priorityQueue.Dequeue());
}

priorityQueue.Enqueue("Hello", 4);
priorityQueue.Enqueue($"PriorityQueue.{Environment.NewLine}", 1);
priorityQueue.Enqueue(" This is a ", 2);
priorityQueue.Enqueue(" world!", 3);

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"{Environment.NewLine}Dequeue using while reverse for:");
Console.ForegroundColor = ConsoleColor.DarkGray;

for (var i = priorityQueue.Count; i > 0; i--)
{
    Console.Write(priorityQueue.Dequeue());
}

Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{Environment.NewLine}Press any key to continue...");
Console.ReadKey();