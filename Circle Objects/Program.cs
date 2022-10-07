using Circle_Objects;

namespace Circle_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initial greeting for user
            Console.WriteLine("Welcome to the Circle Object Generator!");

            bool goOn = true;
            while (goOn == true)
            {
                //Ask user to enter radius
                Console.WriteLine("Enter a radius");
                double radius = double.Parse(Console.ReadLine());
                //Convert user input to a new object
                Circle c = new Circle(radius);

                //Validate user input is a positive integer
                if(radius > 0)
                {
                    //Calculate and display circumference and area using methods created in Class Circle
                    c.CalculateCircumference(radius);
                    Console.WriteLine($"Circumference: {c.CalculateCircumference(radius)}");
                    c.CalculateArea(radius);
                    Console.WriteLine($"Area: {c.CalculateArea(radius)}");
                }
                else
                {
                    Console.WriteLine("Please enter a number with a positive value.");
                }
                goOn = AskToContinue();
            }
        }
        static bool AskToContinue()
        {
            //Variable created to count number of times user creates a circle
            int circleCount = 1;
            circleCount++;

            Console.WriteLine("Would you like to try again? Y/N");
            string response = Console.ReadLine().ToLower();

            if (response == "y")
            {                
                return true;
            }
            else if(response == "n")
            {
                //Return the number of circle objects created with goodbye message
                Console.WriteLine($"Circles made: {circleCount} \nThank you for using the Circle Object Generator. Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry. I didn't understand that. Please, try again.");
                return AskToContinue();
            }
        }
    }
}


