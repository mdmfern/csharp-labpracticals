namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.question1();

            p.question2();

            p.question3();

            p.question4();
        }

        void question1()
        {
            Console.WriteLine("Enter the Number :");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("ODD Number");
            }
        }
        void question2()
        {
            Console.WriteLine("Enter a word:");
            string str = Console.ReadLine();
            int vowelCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("The number of vowels in this string is {0}.", vowelCount);
        }

        void question3()
        {
            Console.WriteLine("Enter a Number:");
            int number = int.Parse(Console.ReadLine());

            int tot = 0;
            while (number > 0)
            {
                int digit = number % 10;
                tot += digit;
                number /= 10;
            }

            Console.WriteLine("Sum of the Digit = {0}", tot);

        }

        void question4()
        {
            Console.WriteLine("Enter a Number:");
            int number = int.Parse(Console.ReadLine());

            int tot = 0;

            while (number > 0)
            {
                int digit = number % 10;

                if (number % 2 == 1)
                {
                    tot += digit;
                }
                number /= 10;
            }

            Console.WriteLine("Sum of the Digit = {0}", tot);


        }




    }
}