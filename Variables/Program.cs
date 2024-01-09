namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; //declaration 
            x = 11; //initialisation 
            int y = 22; // declaration & initialisation
            int z = x + y;

            // Outputting all the previous variables and the sum of x & y 
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            int age = 28; // int stores a whole number
            double height = 181.5; //double stores decimal numbers 
            bool alive = true; //only two states 
            char symbol = '@'; 
            String name = "Nathan";

            const double pi = 3.14159; // Constants are values that 

            // This section is outputting all the variables as an example of each
            Console.WriteLine("Hello " + name);
            Console.WriteLine("My age is " + age);
            Console.WriteLine("My height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is " + symbol);

            // This section is just an example for a String combined with the char variable 
            String username = symbol + name;
            Console.WriteLine("Your username is: " + username);

            // This takes in user input before displaying the debug log
            Console.ReadKey();
        }
    }
}
