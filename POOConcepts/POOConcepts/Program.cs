using System;

namespace POOConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO Concepts");
            Console.WriteLine("------------");
            // Date date1 = new Date(2022, 6, 3);
            //la clase date hereda de la clase Object
            //Console.WriteLine(date1);
            //ctr + k + s (sorround with (rodear con) para realizar de mejor manera un try catch
            try
            {
                Console.WriteLine(new Date(2022, 12, 7));
                Console.WriteLine(new Date(1990, 12, 12));
                //Console.WriteLine(new Date(1885, 20, 12)); //invalid month
                Console.WriteLine(new Date(1885, 2, 30)); //invalid day

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message); //esta clase hereda  desde MonthException
            }
        }
    }
}
