public class Room
{
    static Semaphore semaphore = new Semaphore(initialCount: 3, maximumCount: 3);
    Thread myThread;
    static int count; // sanoq

    public Room(int i)
    {
        count = 3;
        myThread = new Thread(ManageCapacity);
        myThread.Name = $"Visitor {i}";
        myThread.Start();
    }

    public void ManageCapacity()
    {
        while (count > 0)
        {
            semaphore.WaitOne();

            Console.WriteLine($"{Thread.CurrentThread.Name} has arrived");

            Console.WriteLine($"{Thread.CurrentThread.Name} is seated..");
            Thread.Sleep(1500);

            Console.WriteLine($"{Thread.CurrentThread.Name} has left");
            Thread.Sleep(1000);

            semaphore.Release();

            count--;

        }
    }
}
