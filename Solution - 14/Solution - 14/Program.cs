namespace Solution___14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            int chain= 0;

            for (int number = 1000000; number > 0; number--)
            {
                int count = 0;
                int a = number;
                while (a > 1)
                {
                    if (a % 2 == 0)
                    {
                        a = a / 2;
                        count++;
                    }
                    else
                    {
                        a = (a * 3) + 1;
                        count++;
                    }
                }

                if (count > chain)
                {
                    chain = count;
                    Console.WriteLine(number);
                    
                }
                
            }
        }
    }
}