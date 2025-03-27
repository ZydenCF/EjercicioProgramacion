using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacion
{
    public class CaminoIzquierdo : Escena
    {
        public override void Mostrar()
        {
            Console.WriteLine("Tomas el camino izquierdo y encuentras un río. Puedes cruzar o seguir la orilla.");
        }

        public override Escena TomarDecision(string eleccion)
        {
            if (eleccion.ToLower() == "cruzar")
            {
                return new FinalMalo();
            }
            else if (eleccion.ToLower() == "seguir")
            {
                return new FinalBueno();
            }
            else
            {
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                return this;
            }
        }
    }
}
