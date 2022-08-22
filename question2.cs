

namespace assignment
{
    internal class question2
    {
        public static void Main()
        {
            int num1, num2;
            Console.WriteLine("Enter First Number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($"{num2} is smaller");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"{num1} is smaller");
            }
            else
            {
                Console.WriteLine("They are Equal");
            }

        }
    }
}