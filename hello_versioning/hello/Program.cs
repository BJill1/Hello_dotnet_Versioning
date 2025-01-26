namespace hello;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number");
        var num = int.Parse(Console.ReadLine());
        Console.WriteLine("The number you entered is " + num);
    }
}
