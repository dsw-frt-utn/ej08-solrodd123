namespace Dsw2026Ej8
{
    public static class Extensions
    {
        public static string ToProductCode(this string value)
        {
            // Si el código es null, debe retornar "SIN-CODIGO"
            if (value == null) return "SIN-CODIGO";

            // 1. Eliminar espacios al inicio y final (Trim)
            // 2. Reemplazar espacios internos por guiones (Replace)
            // 3. Convertir a mayúsculas (ToUpper)
            return value.Trim().Replace(" ", "-").ToUpper();
        }
    }
}