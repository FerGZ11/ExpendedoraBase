using System;
using System.Threading;

namespace ExpendedoraBase
{
    class Expendedora
    {
        string marca;
        private byte temperatura;
        public string codigo;
        float precio;

        public float Precio
        {
            get => precio;
            set
            {
                if (value >= 10 && value <= 50)
                {
                    precio = value;
                }
                else
                {
                    precio = 10;
                }
            }
        }

        public byte Temperatura
        {
            get => temperatura;
            set
            {
                if (value >= 10 && value <= 18)
                {
                    temperatura = value;
                }
                else
                {
                    temperatura = 14;
                    //Console.WriteLine("Temperatura fuera de rango");
                }
            }
        }

        public Expendedora()
        {
            Saludar();
            ControlarTiempoDisplay();
            marca = "AMS";
            Console.WriteLine("Marca {0}", marca);
        }

        public Expendedora(bool soporte)
        {
            Console.WriteLine("Entrando en modo soporte");
            Console.WriteLine("La temperatura actual es : {0}", Temperatura);
        }

        public void Saludar()
        {
            Console.WriteLine("Bienvenido");
        }
        public string MostrarCodigoDeProducto()
        {
            Console.WriteLine("A1: Kinder Delice\tB2: Takis\tC3: Donitas");
            Console.WriteLine("Ingrese el código del producto deseado: ");
            string codigo = Console.ReadLine();
            return codigo;
        }
        public void ControlarTiempoDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }
        public void MostrarPrecio(string codigo)
        {
            Precio = 0;
            switch (codigo)
            {
                case "A1":
                    Precio -= 50;
                    Console.WriteLine("El precio es {0}", Precio);
                    break;
                case "B2":
                    Precio += 5;
                    Console.WriteLine("El precio es {0}", Precio);
                    break;
                case "C3":
                    Precio += 10;
                    Console.WriteLine("El precio es {0}", Precio);
                    break;
                default:
                    Console.WriteLine("Producto no reconocido");
                    break;
            }
        }
    }
}
