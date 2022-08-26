using System;

namespace ExpendedoraBase
{
    internal class Snack:Expendedora
    {
        public Snack()
        {
            Temperatura = 14;
            Console.WriteLine("Temperatura interna {0}°C", Temperatura);
            ControlarTiempoDisplay();
            codigo = MostrarCodigoDeProducto();
            Console.Clear();
            MostrarPrecio(codigo);
        }
    }
}
