using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacion
{
    public class Inicio : Escena
    {
        public override void Mostrar()
        {
            Console.WriteLine("Estás en un bosque oscuro. Hay dos caminos: uno a la izquierda y otro a la derecha.");
        }

        public override Escena TomarDecision(string eleccion)
        {
            if (eleccion.ToLower() == "izquierda")
            {
                return new CaminoIzquierdo();
            }
            else if (eleccion.ToLower() == "derecha")
            {
                return new CaminoDerecho();
            }
            else
            {
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                return this;
            }
        }
    }
}
