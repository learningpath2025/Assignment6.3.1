namespace Assignment6._3._1
{
    internal class Program
    {
        public static void CallQueueManager()
        {
            // Create a queue of callers (strings in this case)
            Queue<string> callQueue = new Queue<string>();

            // Enqueueing elements into the queue
            Console.WriteLine("Enqueueing callers:");
            callQueue.Enqueue("Customer A");
            Console.WriteLine($"Enqueued: Customer A. Current queue size: {callQueue.Count}");
            callQueue.Enqueue("Customer B");
            Console.WriteLine($"Enqueued: Customer B. Current queue size: {callQueue.Count}");
            callQueue.Enqueue("Customer C");
            Console.WriteLine($"Enqueued: Customer C. Current queue size: {callQueue.Count}");

            Console.WriteLine("\nIterating over the elements in the queue (without dequeuing):");
            foreach (string caller in callQueue)
            {
                Console.WriteLine($"Caller in queue: {caller}");
            }

            // Dequeuing elements from the queue
            Console.WriteLine("\nDequeuing callers:");
            while (callQueue.Count > 0)
            {
                string dequeuedCaller = callQueue.Dequeue();
                Console.WriteLine($"Dequeued: {dequeuedCaller}. Remaining queue size: {callQueue.Count}");
            }

            Console.WriteLine("\nQueue is now empty.");
        }
        static void Main(string[] args)
        {
            CallQueueManager();
        }
    }
}
