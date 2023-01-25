namespace Fibonacci_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> {1,1};
            
            for(int i = 0; i < 20; i++)
            {
                if(i != 0)
                {
                    var previous = numbers[i - 1];
                    numbers.Add(previous + numbers[i]);
                }
                Console.WriteLine(numbers[i]);
            }

        }
    }
}