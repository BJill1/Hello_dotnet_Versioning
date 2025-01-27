namespace hello;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number");
        var num = int.Parse(Console.ReadLine());
        if(num%2 == 0){
            Console.WriteLine("The number you entered is even");
        } else{
            Console.WriteLine("The number you entered is odd");
        }
    }
}
