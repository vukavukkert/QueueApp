using QueueApp;
Queue queue = new Queue(10);
for (int i = 0; i < queue.Length; i++)
{
    queue.Enqueue(i + 1);
    Print(queue.Peek());
}
static void Print(int a)
{
    Console.WriteLine(a);
}
