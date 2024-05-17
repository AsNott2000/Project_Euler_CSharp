namespace solution___6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

            int first_product;
            int first_sum = 0;
            for (int i = 1; i < 101; i++)
            {
                first_product = i * i;
                first_sum += first_product;
            }
            int second_sum = 0;
            int second_product;
            for (int k = 0; k < 101; k++)
            {
                second_sum += k;
                
            }
            second_product = second_sum * second_sum;

            int last = second_product - first_sum;

            Console.WriteLine(last);
        }
    }
}