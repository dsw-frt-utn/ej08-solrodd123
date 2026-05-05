namespace Dsw2026Ej8
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            // Condición: si quantity es menor o igual a 0, el total debe ser 0
            decimal totalCalculado = quantity > 0 ? (quantity * unitPrice) : 0;

            // Creación de la clase anónima según la consigna
            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = totalCalculado
            };

            // Formato de retorno: Code-Description-Total
            return $"{resumen.Code}-{resumen.Description}-{resumen.Total:C}";
        }
    }
}
