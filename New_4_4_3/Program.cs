namespace New_4_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Артур", 16);
            Console.WriteLine("Your name is {0} and your age is {1}", name, age);
            Console.WriteLine("Enter your name: ");
           
            name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Your name is {0} and your age is {1}", name, age);
            Console.ReadKey();
        }
    }
}