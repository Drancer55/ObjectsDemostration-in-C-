using System;
using System.Collections.Generic;

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
                Salary = 10000.50M //M = money
            };
            Employee employee2 = new CommissionEmployee() //new dispara el contructor
            {
                Id = 1020,
                FirstName = "Ilse",
                LastName = "Martinez",
                BirthDay = new Date(1994, 11, 1),
                Hiringdate = new Date(2022, 6, 2),
                IsActive = true,
                Sales = 15000.50M,
                CommissionPorcentage = 0.03F //constante Float (porcentaje)
            };
            Employee employee3 = new HourlyEmployee()
            {
                Id = 1030,
                FirstName = "Erika",
                LastName = "Hernandez",
                BirthDay = new Date(1985, 10, 10),
                Hiringdate = new Date(2021, 11, 2),
                IsActive = true,
                HourValue = 25000.50M,
                Hours = 100.2F //constante Float (porcentaje de la hora trabajada)
            };
            Employee employee4 = new BaseCommissionEmployee()
            {
                Id = 1040,
                FirstName = "Liliana",
                LastName = "Gonzales",
                BirthDay = new Date(1988, 11, 11),
                Hiringdate = new Date(2021, 11, 1),
                IsActive = true,
                Base = 8000M, 
                Sales = 10000M,
                CommissionPorcentage = 0.10F
            };

            //Crear lista de empleados: Interface = comienza con "I" (Icollection), se imprimen en un ciclo.
            ICollection<Employee> employees = new List<Employee>()
            {
                employee1, employee2, employee3, employee4
            };
            // Calcular el valor total de la Nómina
            decimal payroll = 0;
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                payroll += employee.GetValueToPay(); //se suma la nómina
            }
            Console.WriteLine("               ===============");
            Console.WriteLine($"TOTAL:        {$"{payroll:C2}", 15}"); //doble interpolación para alinear los números, 15 caracteres a la izq.

            Invoice invoice = new Invoice()
            {
                Description = "Iphone13",
                Id = 1,
                Price = 2500M,
                Quantity = 10
            };
            Invoice invoice2 = new Invoice()
            {
                Description = "Meat Premium",
                Id = 2,
                Price = 1000M,
                Quantity = 9
            };

            Console.WriteLine(invoice);
            Console.WriteLine(invoice2);

            //Empleados individuales, escritos uno a uno
            //Console.WriteLine(employee1); // muestra los datos del empleado1
            //Console.WriteLine(employee2); // muestra los datos del empleado2
            //Console.WriteLine(employee3); // muestra los datos del empleado3
            //Console.WriteLine(employee4); // muestra los datos del empleado4

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
