using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public interface Ipay //público
    {
        public decimal GetValueToPay(); //se define el contrato, todas las clases que implementen esta interface, tiene por obligacion implementar getValueToPay();
    }
}
