namespace solution___3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //What is the largest prime factor of the number 600851475143


            long x = 600851475143;
            int i = 1;
            int bolen = 2;

            while (x >= bolen)
            {
                if (x % bolen == 0)
                {
                    x /= bolen;
                    Console.WriteLine(i + ". element :" + bolen);
                    i += 1;
                }
                else
                {
                    bolen += 1;
                }
            }
        }
    }
}