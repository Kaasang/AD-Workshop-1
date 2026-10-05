using Task2;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("PI = " + Circle.PI);
        Circle.PI = 3.14159;  //Pi in circle class is declared as const that is why when we try to change the value it throws an error.
        
        
    }
}