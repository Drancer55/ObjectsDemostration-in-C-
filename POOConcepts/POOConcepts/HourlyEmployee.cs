namespace POOConcepts
{
    class HourlyEmployee : Employee //Empleado que trabaja por horas
    {
        public float Hours { get; set; } //float se maneja con decimales para añadir los minutos que puedan sobrar

        public decimal HourValue { get; set; }
        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue; //Retorna cantidad de horas trabajadas por el valor de la ahora
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHours................: {$"{Hours:P2}",18}" + //P2 formato de porcentage con 2 decimales //numeric-2 "N2" (le da formato de número con 2 decimales)
                $"\n\tHour value...........: {$"{HourValue:C2}",18}" +
                $"\n\tValue to Pay.........: {$"{GetValueToPay()}",18}"; // otra linea \n tabulador \t
        }
    }
}
