namespace Dsw2026Ej8
{
    public class Problema6
    {
        public string NormalizarCodigoProducto(string code)
        {
            // Llama al método de extensión que creamos arriba
            return code.ToProductCode();
        }
    }
}