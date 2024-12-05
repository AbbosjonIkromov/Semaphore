using System.Threading;


Console.Write("1 - Task:\n2 - Task:\n-> ");
int number = int.Parse(Console.ReadLine());

switch(number)
{
    case 1:
        for(int i = 1; i < 5; ++i)
        {
            Room room = new Room(i);
        }
        break;
    case 2:
        for(int i = 1; i < 5; ++i)
        {
            Printer printer = new Printer(i);
        }
        break;
    default:
        Console.WriteLine("Belgilanman malumot kiritildi!");
        break;
}