namespace LinqExampleForMinMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = { "10", "5", "100", "30", "50", "abc", "pqr" };

            var integers = numbers.Where(n => int.TryParse(n, out int v));

            int maxNumber=integers.Select(n => int.Parse(n)).Max();
            Console.WriteLine($"Max Number: {maxNumber}");
            int secondMaxNumber = integers.Select(n => int.Parse(n)).Where(n => n < maxNumber).Max();
            Console.WriteLine($"Second Max Number: {secondMaxNumber}");
          
            int minNumber = integers.Select(n => int.Parse(n)).Min();
           
            Console.WriteLine($"Min Number: {minNumber}");
            int sum = integers.Select(n => int.Parse(n)).Sum();
            Console.WriteLine($"Sum of Numbers: {sum}");

            Console.Write("Descending : ");
            integers.Select(n => int.Parse(n)).OrderByDescending(n => n).ToList().ForEach(n=>Console.Write(n+" "));

        }
    }
}