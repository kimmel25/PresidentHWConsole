namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DOV KIMMEL, T00505770
            int age;
            bool citizenOrNo;
            bool rebelledOrNo;
            bool impeachedOrNo;
            int yearsServed;
            int amountOfTimeInUS;

            while (true)
            {
                Console.WriteLine("How old are you?");
                var input = Console.ReadLine();

                if (int.TryParse(input, out age) && age > 0)
                {
                    Console.WriteLine($"You are {age}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please put in a valid integer.");
                }

            }

            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Are you a natural born citizen? Please type true or false");
                var input = Console.ReadLine();

                if (bool.TryParse(input, out citizenOrNo))
                {
                    Console.WriteLine($"You are {citizenOrNo}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please put in true or false.");
                }

            }

            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("How long have you been living in the US for?");
                var input = Console.ReadLine();

                if (int.TryParse(input, out amountOfTimeInUS) && amountOfTimeInUS > 0)
                {
                    Console.WriteLine($"You have been in the US for {amountOfTimeInUS}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please put in a valid integer.");
                }

            }

            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Have you been impeached? Please type true or false");
                var input = Console.ReadLine();

                if (bool.TryParse(input, out impeachedOrNo))
                {
                    Console.WriteLine($"You are impeached: {impeachedOrNo}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please put in true or false.");
                }

            }


            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Have you ever rebelled against the US? Please type true or false");
                var input = Console.ReadLine();

                if (bool.TryParse(input, out rebelledOrNo))
                {
                    Console.WriteLine($"You are rebelled: {rebelledOrNo}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please put in true or false.");
                }

            }


            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("How many terms have you served as president?");
                var input = Console.ReadLine();

                if (int.TryParse(input, out yearsServed) && yearsServed > 0)
                {
                    Console.WriteLine($"You have been in the US for {yearsServed}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please put in a valid integer.");
                }

            }



            Console.WriteLine();
            if (age >= 35 && citizenOrNo == true && amountOfTimeInUS >= 14 && !impeachedOrNo && !rebelledOrNo && yearsServed <= 2) { Console.WriteLine("You can be president!"); }
            else { Console.WriteLine("You can NOT become president!"); }

        }
    }
}