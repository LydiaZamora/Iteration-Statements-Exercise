namespace IterationStatements
{
    public class Program
    {
       

        static void Main(string[] args)
        {
            // 1. PrintThousand();

            // 2. IncreaseByThree();

            // 3. Console.WriteLine(counterTwo(2,8));

            // 4. EvenOrOdd(9);

            // 5. IsPositive(-45);

            // 6.  Console.WriteLine("Hello, how old are you?");
             //string userResponse = Console.ReadLine();
             //int age = int.Parse(userResponse);
             //OfVotingAge(age); 

            // 7. NumberRange(-3); 

            //MultiplyTable(); 

        }

        //1. Write a method that will print to the console all
        //numbers 1000 through -1000.

        public static void PrintThousand()
        {

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }

        // 2. Write a method that will print to the console numbers
        //3 through 999 by 3 each time.

        public static void IncreaseByThree()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        // 3. Write a method to accept two integers as parameters and
        //check whether they are equal or not.

        public static bool counterTwo(int a, int b)
        {
            if (a == b)
            {
                return true;
            }

            return false;
        }


        // 4. Write a method to check whether a given
        //number is even or odd.

        public static void EvenOrOdd(int number)
        {
       
            if (number % 2 == 0)
            {
                Console.WriteLine("even steven");
            }

            else
            {
                Console.WriteLine("odd duck");
            }
        }


        // 5. Write a method to check whether a given number is
        //positive or negative. NEED HELP

        public static bool IsPositive(int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine("Positive");
                return true;
            }

            Console.WriteLine("negative");
            return false;
        }

        // 6. Write a method to read the age of a candidate and
        //determine whether they can vote

        public static void OfVotingAge(int age)
        {
            
            if (age >= 18)
            {
                Console.WriteLine("Cool, you can vote.");
            }

            else
            {
                Console.WriteLine("You're too young to vote, try again next time.");
            }
            
        }

        //Write a method to check if an integer(from the user)
        //is in the range -10 to 10

        public static void NumberRange(int numberOne)
        {
            if(numberOne >= -10 && numberOne <= 10)
            {
                Console.WriteLine("You are in range");
            }

            else
            {
                Console.WriteLine("You are out of range");
            }
        }

        //Write a method to display the
        //multiplication table(from 1 to 12) of a given integer

        public static void MultiplyTable()
        {
            Console.WriteLine(" Choose a number ");
            var userAnswer = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 12; i++)
            {
                var answer = i * userAnswer;

                Console.WriteLine(answer);

            }
            

            
        }



    }

}
