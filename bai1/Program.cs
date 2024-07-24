
using baithic;

class Program
{
    static void Main()
    {
        People person = new People();
        
        Console.WriteLine("Enter Name:");
        person.Name = Console.ReadLine();

        Console.WriteLine("Enter Gender (true for Male, false for Female):");
        person.Gender = bool.Parse(Console.ReadLine());

        Console.WriteLine("Enter Age:");
        person.Age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of years to increment:");
        int incrementValue = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nSimple Properties Demo");
        person.DisplayInfo();
        
        person.IncrementAge(incrementValue);
        
        Console.WriteLine("\nAfter incrementing age:");
        person.DisplayInfo();
    }
}