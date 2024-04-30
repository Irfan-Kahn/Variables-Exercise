namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Ralph";
            int dogAge = 2;
            char inital = 'R';
            double eatingCost = 19.9;
            bool is1YearOld = true;
            decimal price = 200.00m;
            Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old");
            Console.WriteLine($" {dogName}'s initail are, just {inital}");
            Console.WriteLine($" {dogName}'s eating cost per week is {eatingCost}");
            Console.WriteLine($" Is {dogName} over 1 ?: {is1YearOld}");
            Console.WriteLine($"I bought {dogName} for ${price}, when he was a babay");

        }
    }
}
