using System;

namespace ExpendedoraBase
{
    internal class Cafe:Expendedora
    {
        public Cafe()
        {
            Temperatura = 90;
            Console.WriteLine("La temperatura es: {0}°C", Temperatura);
            ControlarTiempoDisplay();
        }
    }
}
