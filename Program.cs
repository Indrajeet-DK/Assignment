/*** exercise 01***/
namespace assignment
{
    internal class Assignment
    {
        public static void Main()
        {
            int num1;
            int num2;
            int num3;

            Console.Write("enter the 1st number ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter the 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter the 3rd number");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine($"the answer is {result}");
        }
    }
}