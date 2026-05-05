using System;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int?[] notas = { nota1, nota2, nota3 };
            int suma = 0;
            int cantidadValidas = 0;

            foreach (int? nota in notas)
            {
                // Verifica que tenga valor y esté entre 0 y 10 según la consigna
                if (nota.HasValue && nota.Value >= 0 && nota.Value <= 10)
                {
                    suma += nota.Value;
                    cantidadValidas++;
                }
            }

            // Si no hay notas válidas o todas son null, retorna 0
            return cantidadValidas == 0 ? 0 : (double)suma / cantidadValidas;
        }
    }
}