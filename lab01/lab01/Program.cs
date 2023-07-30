namespace labsheet
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
            Console.Write("Enter the name : ");
            string name = Console.ReadLine();
            
            Console.Write("Enter the batch : ");
            string batch = Console.ReadLine();

            Console.WriteLine(" I am {0}. My batch is {1}", name, batch);
        }

        void question2()
        {
            Console.Write("Enter the radius of the circle : ");
            float radius = float.Parse(Console.ReadLine());

            Console.Write("The area of the circle is {0} ", 3.14 * radius * radius);

        }

        void question3()
        {
            Console.Write("Enter the number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number 2 :  ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Sumation of 2 number is {0}", num1 + num2);
        }

        void question4()
        {
            Console.Write("Enter the salary : ");
            float salary = float.Parse(Console.ReadLine());

            Console.Write("Enter the Tax rate : ");
            float tax = float.Parse(Console.ReadLine());

            float tax_payment = salary * tax / 100;
            float amount_remain = salary - tax_payment;

            Console.Write("The salary after the Tax = {0}", amount_remain);

        }




    }
}