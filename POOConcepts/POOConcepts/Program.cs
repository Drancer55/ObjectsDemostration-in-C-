using System;

namespace POOConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO Concepts");
            Console.WriteLine("------------");
            Employee employee1 = new SalaryEmployee() //new dispara el contructor
            {
                Id = 1010,
                FirstName = "Oscar",
                LastName = "Ruiz",
                BirthDay = new Date(1990, 12, 28),
                Hiringdate = new Date(2022, 6, 1),
                IsActive = true,
                Salary= 10000.50M //M = money
            };
            Employee employee2 = new CommissionEmployee() //new dispara el contructor
            {
                Id = 1010,
                FirstName = "Ilse",
                LastName = "Martinez",
                BirthDay = new Date(1994, 11, 1),
                Hiringdate = new Date(2022, 6, 2),
                IsActive = true,
                Sales = 15000.50M,
                CommissionPorcentage = 0.03F //constante Float (porcentaje)
            };
            Console.WriteLine(employee1); // muestra los datos del empleado1
            Console.WriteLine(employee2); // muestra los datos del empleado1


            // Date date1 = new Date(2022, 6, 3);
            //la clase date hereda de la clase Object
            //Console.WriteLine(date1);
            //ctr + k + s (sorround with (rodear con) para realizar de mejor manera un try catch
            //try
            //{
            //    Console.WriteLine(new Date(2022, 12, 7));
            //    Console.WriteLine(new Date(1990, 12, 12));
            //    //Console.WriteLine(new Date(1885, 20, 12)); //invalid month
            //    Console.WriteLine(new Date(1885, 2, 30)); //invalid day

            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine(error.Message); //esta clase hereda  desde MonthException
            //}
        }
    }
}
