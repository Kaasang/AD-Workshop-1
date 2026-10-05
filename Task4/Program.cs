public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1,2,3,4,5 };
        
        Array.Sort(numbers);
        Array.Reverse(numbers);
        
        Console.WriteLine("Array after sort and reverse:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element " + i + " : " + numbers[i]);
        }

        int position = Array.IndexOf(numbers, 7);
        Console.WriteLine("Position of 7 is: " + position);
    }
}