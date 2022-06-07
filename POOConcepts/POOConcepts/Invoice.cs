namespace POOConcepts
{
    public class Invoice : Ipay //la clase implementa la interface
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }
        public override string ToString() //toString para imprimirlo
        {
            return $"{Id} - {Description}" +
                $"\n\tQuantity.............: {$"{Quantity:N2}",18}" + //impresión de la variable Quantity
                $"\n\tPrice................: {$"{Quantity:C2}",18}" +
                $"\n\tValue................: {$"{GetValueToPay():C2}",18}";
        }
    }
}
