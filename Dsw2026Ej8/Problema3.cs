using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiaValue = originalValue;

            copiaValue++;

            Product copiaProduct = product;

            copiaProduct.DescriptionProduct = "Descripcion Modificada";

            return $"{originalValue}-{copiaValue}-{product.DescriptionProduct}";
        }
    }
}
