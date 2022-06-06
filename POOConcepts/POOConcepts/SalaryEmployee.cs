using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class SalaryEmployee : Employee //cuando hereda de una clase abstracta se obliga a heredar los métodos abstractos
    {
        public decimal Salary { get; set; } //'decimal' se utuliza en el manejo de dinero
        public override decimal GetValueToPay()
        {
            return Salary;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" + 
                $"\n\tValue to Pay.........: {$"{GetValueToPay():C2}", 18}"; // otra linea \n tabulador \t // se aplica doble interpolación $ y se le indica el número de caracteres que  usará (independientemente de la cantidad a mostrar) 
        }

    }
}
