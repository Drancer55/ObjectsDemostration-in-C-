//los Using son librerias que se agregan por defecto
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//equivalete al Package en Java
namespace POOConcepts
{
    public class Date
    {
        //estandar refactor con underline prefijo (_) atributo privado
        private int _year; 
        private int _month;
        private int _day;

        public Date()
        {
        }

        // constructor... snippet: son abreviaturas de código que ayudan a ser más productivo
        public Date(int year, int month, int day)
        {
            //this.year = year; (ya no se utiliza)
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(year, month, day);
        }

        private int CheckDay(int year, int month, int day)
        {
            //un año dura 365.25 días y se ajustan cada 4 años (se compensa cada 4 años), cada 100 años no es biciesto, en el 2400 sí será (cada 400 años)
            //Lo métodos que son booleanos regularmente comienzan con "Is" por retornar false o true
            //para el mes de febrero:
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }

            throw new DayException("Día inválido");
        }

        private bool IsLeapYear(int year)
        {
            //forma más limpia de declaración 
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;

            //Forma de saber si un año es biciesto 
            //MODULO = Multiplo de 4
            //    if (year % 4 == 0) //se calcula si el modulo del año (cada 4 años) es == 0
            //    { 
            //        if (year % 100 == 0) //se calcula si el modulo del año (cada 100 años) es == 0
            //        {
            //            if (year % 400 == 0) //se calcula si el modulo del año (cada 100 años) es == 0
            //            {
            //                return true;
            //            }
            //            else //return de cada 400 años
            //            {
            //                return false; 
            //            }
            //        }
            //        else //return de cada 100 años
            //        {
            //            return true;
            //        }
            //    }
            //    else //return de cada año
            //    {
            //        return false;
            //    }
        }

        //método para validar que el mes que ha entrado es correcto
        private int CheckMonth(int month)
        {
            //el mes debe estar entre 1 y 12
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            //lanza 
            throw new MonthException($"Mes inválido");
        }

        //Sobreescritura, metodos susebtibles de sobreescritura
        public override string ToString()
        {
            //devuelve la ejecución del método padre
            //turn _year + "/" + _month + "/" + _day;
            //Interpolación de String en C# para no sumar los parámetros
            return $"{_year}/{_month:00}/{_day:00}"; 
        }
    }
}
