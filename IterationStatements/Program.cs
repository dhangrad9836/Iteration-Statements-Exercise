namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintRange(int ceiling, int floor)
        {
            for(int i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void CountByThree()
        {
            for(int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool CheckTwoInts(int num1, int num2)
        {
            //check whether num1 is equal to num2
            if(num1 == num2)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
        
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num)
        {
            //check if user input is even or odd
            if(num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else if(num % 2 == 1)
            {
                Console.WriteLine("Odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative(int num)
        {
            //check if user input is positive or negative
            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VotingEligiblity(string ageNumber)
        {
            //check user input if it's a number
            if(int.TryParse(ageNumber, out int age))
            {
                if(age >= 18)
                {
                    Console.WriteLine("You can vote");
                }
                else
                {
                    Console.WriteLine("You are not old enough to vote.");
                }
            }
            else
            {
                Console.WriteLine("You did not enter a number.");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void NumberRangeChecker(int num)
        {
            //check users input if it's in the range of -10 to 10
            if((num >= -10) && (num <= 10))
            {
                Console.WriteLine($"{num} is in range.");
            }
            else
            {
                Console.WriteLine($"{num} is not in range.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void Multiplier(int num)
        {
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} * {i} = " +
                    $"{num * i}");
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintRange(1000, -1000);

            CountByThree();

            Console.WriteLine(CheckTwoInts(2, 2));

            EvenOrOdd(8);

            PositiveOrNegative(-8);

            Console.WriteLine("Enter your age to determine if you are eligible to vote: ");
            var votingAge = Console.ReadLine();
            VotingEligiblity(votingAge);

            Console.WriteLine("Enter a number to check if it's in range: ");
            int numberInRange = int.Parse(Console.ReadLine());
            NumberRangeChecker(numberInRange);

            Multiplier(2);

            Console.ReadLine();
        }
        
    }
}
