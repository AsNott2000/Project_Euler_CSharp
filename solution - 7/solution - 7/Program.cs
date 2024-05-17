namespace solution___7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // What is the 10 001st prime number?

            int sayac = 0;
            int son_basamak = 0;
            for (int num = 2; num <= 9999999; num++)
            {
                int kontrol = 0;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0) 
                    {
                        kontrol = 1;
                        break;
                    }
                }
                if (kontrol != 1)
                {
                    sayac++;
                    son_basamak++;
                    if (son_basamak == 10001)
                    {
                        Console.WriteLine("10 001st prime number: {0}", num);
                        break;
                    }
                }
                
            }
            

        }
    }
}
