
namespace baithic;

public class People
{
    public string Name { get; set; }
    public bool Gender { get; set; } 
    public int Age { get; set; }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Person details: Name = {Name}, Gender = {(Gender ? "Male" : "Female")}, Age = {Age}");
    }
    
    public void IncrementAge(int incrementValue)
    {
        Age += incrementValue;
    }
}