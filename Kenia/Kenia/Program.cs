using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kenia
{
    class Program
    {
        static void Main(string[] args)
        {
            double masa, presion, temperatura, volumen;
            char tecla_repetir;
            do
            {
                Console.Write("Ingrese el valor de presion: ");
                presion = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el valor de temperatura: ");
                temperatura = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el valor de volumen: ");
                volumen = double.Parse(Console.ReadLine());
                masa = presion * volumen / 0.37 / (temperatura + 460);
                Console.WriteLine("Valor de masa: " + masa);
                Console.WriteLine();
                Console.Write("\u00BFDesea repetir el proceso? (S/N): ");
                do
                {
                    tecla_repetir = Console.ReadKey().KeyChar;
                } while (tecla_repetir != 's' && tecla_repetir != 'n' && tecla_repetir != 'S' && tecla_repetir != 'N');
            } while (tecla_repetir == 's' || tecla_repetir == 'S');

            //15. La presión, volumen y temperatura de una masa de aire se relacionan por la formula:
           // masa = presión * volumen.
         //0.37 * (temperatura + 460)
   // Calcular el promedio de masa de aire de los neumáticos de n vehículos que están en compostura en un servicio de alineación y balanceo. Los vehículos pueden ser motocicletas o automóviles.

        }
    }
}
