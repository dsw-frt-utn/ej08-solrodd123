namespace Dsw2026Ej8
{
    // Clase base con el método virtual solicitado
    public abstract class Sale
    {
        public decimal Amount { get; set; }

        public virtual decimal CalculateTotal()
        {
            return Amount;
        }
    }

    // Venta minorista: retorna el importe sin descuento
    public class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Amount;
        }
    }

    // Venta mayorista: aplica un descuento del 10%
    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Amount * 0.9m;
        }
    }
}