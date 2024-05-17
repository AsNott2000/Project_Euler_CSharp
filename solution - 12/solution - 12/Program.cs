
namespace solution___12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int triangleNum = 0;
            int divisor = 0;

            while (divisor <= 500)
            {
                triangleNum += i;
                i++;

                divisor = 0;

                for (int k = 1; k < Math.Sqrt(triangleNum); k++)
                {
                    if (triangleNum % k == 0)
                    {
                        divisor++;
                    }
                }
                divisor *= 2;
            }

            Console.WriteLine(triangleNum);

        }
    }
}