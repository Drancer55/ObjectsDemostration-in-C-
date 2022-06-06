using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public abstract class Employee
    {
        //get = obtener; set = asignar el valor
        public int Id { get; set; }

        public string FirstName //propiedad en CamelCase
        { get; set; }

        public string LastName { get; set; }

        public Date BirthDay { get; set; }

        public Date Hiringdate { get; set; }

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
                return $"{Id} - {FirstName} {LastName}, " +
                $"Birth: {BirthDay}, " +
                $"Hiring: {Hiringdate}, " +
                $"Is active: {IsActive}";
        }
    }
}
