namespace Assignment6._3._1
{
    internal class Program
    {

        public static void CallerQueue()
        {
            Queue<string> callQueue = new Queue<string>();

            Console.Write("Do you want to make a call?(Yes/No)");
            string? userInput = Console.ReadLine();
            userInput.ToLower();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
                return;
            }

            if (userInput.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thank you for using our service.");
                return;
            }

            while (userInput.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Enter caller name: ");
                string callerName = Console.ReadLine();
                callQueue.Enqueue($"Customer { callerName}");
                Console.WriteLine($"\nCaller {callerName} added to the queue. Current queue size: {callQueue.Count}\n");
                Console.Write("Do you want to make another call?(Yes/No)");
                userInput = Console.ReadLine();
                userInput.ToLower();
            }

            PrintQueue(callQueue);

            DequeueAll(callQueue);
        }
        public static void PrintQueue(Queue<string> callQueue)
        {
            Console.WriteLine("\nIterating over the elements in the queue (without dequeuing):\n");
            foreach (string caller in callQueue)
            {
                Console.WriteLine($"Caller in queue: {caller}");
            }
        }

        public static void DequeueAll(Queue<string> callQueue)
        {
            Console.WriteLine($"\n");
            while (callQueue.Count > 0)
            {
                string dequeuedCaller = callQueue.Dequeue();
                Console.WriteLine($"Dequeued: {dequeuedCaller}. Remaining queue size: {callQueue.Count}");
            }
            Console.WriteLine("\nQueue is now empty.");
        }

        static void Main(string[] args)
        {
            CallerQueue();
        }
    }
}
