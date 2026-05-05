using System;

namespace Dsw2026Ej8
{
    internal class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            // Llama al método polimórfico según el tipo real del objeto
            return sale.CalculateTotal();
        }
    }
}