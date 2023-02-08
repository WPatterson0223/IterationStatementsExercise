namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void oneThousand()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void byThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void equalOrNot(int numberOne, int numberTwo)
        {
            if (numberOne == numberTwo)
            {
                Console.WriteLine("These numbers are equal!");
            }
            else
            {
                Console.WriteLine("These numbers are not equal.");
            }
        }
        
        //Write a method to check whether a given number is even or odd
        public static void evenOrOdd()
        {
            Console.WriteLine("Enter a number to check if it is ever of odd.");
            
            var canParse = int.TryParse(Console.ReadLine(), out int userNumber);
            if (canParse == true)
            {
                if (userNumber % 2 == 0)
                {
                    Console.WriteLine($"{userNumber} is even!");
                }
                else
                {
                    Console.WriteLine($"{userNumber} is odd!");
                }
            }
            else
            {
                Console.WriteLine("This is not a number!");
            }
        }

        
        //Write a method to check whether a given number is positive or negative
        public static void posOrNeg()
        {
            Console.WriteLine("Enter a number to check if it is positive or negative.");
            
            var canParse = int.TryParse(Console.ReadLine(), out int userNumber);
            if (canParse == true)
            {
                if (userNumber >= 0)
                {
                    Console.WriteLine($"{userNumber} is positive.");
                }
                else
                {
                    Console.WriteLine($"{userNumber} is negative.");
                }
            }
            else
            {
                Console.WriteLine("This is not a number!");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void votingAge()
        {
            Console.WriteLine("Enter you age to see if you are of voting age.");
            
            var canParse = int.TryParse(Console.ReadLine(), out int userAge);
            if (canParse == true)
            {
                if (userAge >= 18)
                {
                    Console.WriteLine("Congratulations you can vote!");
                }
                else
                {
                    Console.WriteLine("You cant vote. Go home.");
                }
            }
            else
            {
                Console.WriteLine("This is not a number!");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void tenToten()
        {
            Console.WriteLine("Enter a Number to check if number is in range (-10 - 10)");
            
            var canParse = int.TryParse(Console.ReadLine(), out int userNumber);
            if(canParse == true)
            {
                if (userNumber >= -10 && userNumber <= 10)
                {
                    Console.WriteLine($"{userNumber} is in range.");
                }
                else
                {
                    Console.WriteLine($"{userNumber} is out of range.");
                }
            }
            else
            {
                Console.WriteLine("This is not a number!");
            }
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void multiplyThroughTwelve()
        {
            Console.WriteLine("Enter a number to multiply it by 1 - 12");
            
            var canParse = int.TryParse(Console.ReadLine(), out int userNumber);
            if (canParse == true)
            {
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine(userNumber * i);
                }
            }
            else
            {
                Console.WriteLine("This is not a number!");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            oneThousand();

            byThrees();

            Console.WriteLine("Equal or not: Enter your first number.");
            var canParse1 = int.TryParse(Console.ReadLine(), out int equalNumber1);
            Console.WriteLine("Equal or not: Enter your second number.");
            var canParse2 = int.TryParse(Console.ReadLine(), out int equalNumber2);
            if (canParse1 == false || canParse2 == false)
            {
                Console.WriteLine("One of these is not a number!");
            }
            else
            {
                equalOrNot(equalNumber1, equalNumber2);
            }
            
            evenOrOdd();

            posOrNeg();

            votingAge();

            tenToten();

            multiplyThroughTwelve();
        }
    }
}
