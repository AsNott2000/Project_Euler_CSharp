namespace solution___5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ?

            int num = 100;
            
            while (true)
            {
                int count = 0;
                num++;
                for (int i = 2; i < 21; i++)
                {
                    count++;
                    if (num % i != 0)
                    {
                        break;  
                    }
                    
                }
                

                if (count == 19)
                {
                    break;
                }
            }
            Console.WriteLine(num);
        }
    }
}