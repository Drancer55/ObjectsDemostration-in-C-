namespace POOConcepts
{
    class CommissionEmployee : Employee
    {
        public float CommissionPorcentage { get; set; }//float %

        public decimal Sales { get; set; }


        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPorcentage; //no se puede multiplicar decimal*float, así que se convierte a decimal también (decimal)
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission porcentage: {$"{CommissionPorcentage:P2}",18}" + //P2 formato de porcentage con 2 decimales
                $"\n\tSales................: {$"{Sales:C2}",18}" +
                $"\n\tValue to Pay.........: {$"{GetValueToPay()}",18}"; // otra linea \n tabulador \t
        }
    }
}
