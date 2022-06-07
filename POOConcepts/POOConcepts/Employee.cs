using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public abstract class Employee : Ipay //implementa GetValueToPay() indirectamente por ser abstracto (line 25)
    {
        //get = obtener; set = asignar el valor
        public int Id { get; set; }

        public string FirstName //propiedad en CamelCase
        { get; set; }

        public string LastName { get; set; }

        public Date BirthDay { get; set; }

        public Date Hiringdate { get; set; }

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay(); //une el pago entre una factura y un empleado

        public override string ToString()
        {
                return $"{Id} - {FirstName} {LastName}, " +
                $"Birth: {BirthDay}, " +
                $"Hiring: {Hiringdate}, " +
                $"Is active: {IsActive}";
        }
    }
}
