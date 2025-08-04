namespace Assignment_5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            if (args.Length > 0)
            {
                int num;
                foreach (var arg in args)
                {
                    if(int.TryParse(arg, out num))
                        Console.WriteLine($"{num} : {isPalindrome(num)}");
                }
            }
        }
        static bool isPalindrome(int num)
        {
            if (num < 0)
            {
                return false;
            }

            return num == IntReverse(num);
        }

        static int IntReverse(int num)
        {
            int reverse = 0;
            while(num > 0)
            {
                reverse *= 10;
                reverse += num % 10;
                num /= 10;
            }
            return reverse;
        }
    }
}
