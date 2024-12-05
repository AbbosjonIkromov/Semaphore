using System.Linq.Expressions;

public class Printer
{
    static Semaphore semaphore = new Semaphore(initialCount: 2, maximumCount: 2);
    Thread myThread;
    int count;

    public Printer(int i)
    {
        count = 3;
        myThread = new Thread(PrintDocuments);
        myThread.Name = $"Worker {i}";
        myThread.Start();
    }

    public void PrintDocuments()
    {
        while (count > 0)
        {
            semaphore.WaitOne();

            Console.WriteLine($"{Thread.CurrentThread.Name} is printing...");
            Thread.Sleep(1500);

            Console.WriteLine($"{Thread.CurrentThread.Name} has finished printing");
            Thread.Sleep(1000);

            semaphore.Release();

            count--;

        }
    }
}