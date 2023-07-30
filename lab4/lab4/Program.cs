namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues convert = new ConvertValues();

            Console.WriteLine("Enter Your distance in kilometer: ");
            float km = (float)Convert.ToDecimal(Console.ReadLine());

            float meter = convert.KilometerTometer(float km);
            Console.WriteLine("Your distance in Kilometer is: " + meter);


            Console.ReadKey();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Object creation
            FindValues values = new FindValues();

            //Getting radius from user
            Console.WriteLine("Enter your circles radius: ");
            float r = (float)Convert.ToDecimal(Console.ReadLine());

            float area = values.FindArea(r);
            float circum = values.FindCircumference(r);

            Console.WriteLine("Your circle's area is: " + area);
            Console.WriteLine("Your circle's circumference is: " + circum);

            Console.ReadKey();
        }
    }
}