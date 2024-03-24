# GameStructures
 A collection of useful game development data structures.
 > :memo: **Note:** Built using [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).
 ## Usage
  ### Release
   To include in your project see releases. Once a release is downloaded just include the DLL in your project's dependencies list.
  ### Source
   Want to view source and run the test app? Just clone or download the repo and run [GenerateSolution.ps1](/GenerateSolution.ps1).
 ## List of Structures
  ### Priority Queue
   A generic queue that assigns a priority to an element. It is commonly used for pathfinding over graph structures. Currently supports both enqueuing and dequeuing as well as peeking the next element.
   #### Example snippets
    PriorityQueue<string> queue = new PriorityQueue<string>();
    queue.Enqueue("Hello", 4);
    queue.Enqueue("PriorityQueue.", 1);
    queue.Enqueue(" This is a ", 2);
    queue.Enqueue(" world!", 3);

    while (queue.Peek() is not null)
    {
        Console.Write(queue.Dequeue());
    }

    /**
     * Output
     *
     * Hello world! This is a PriorityQueue.
     *
     */
