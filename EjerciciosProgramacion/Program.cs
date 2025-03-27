using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacion
{
    class Program
    {
        static void Main()
        {
            Escena escenaActual = new Inicio();

            while (escenaActual != null)
            {
                escenaActual.Mostrar();

                if (escenaActual is FinalBueno || escenaActual is FinalMalo)
                {
                    escenaActual = escenaActual.TomarDecision("");
                    continue;
                }

                Console.WriteLine("¿Qué Eliges?");
                string decision = Console.ReadLine();
                escenaActual = escenaActual.TomarDecision(decision);
            }

            Console.WriteLine("Gracias por jugar.");
        }
    }
}
