using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacion
{
    public class CaminoDerecho : Escena
    {
        public override void Mostrar()
        {
            Console.WriteLine("Tomas el camino derecho y llegas a una cueva con una luz misteriosa en el fondo.Entrar o Regresar ");
        }

        public override Escena TomarDecision(string eleccion)
        {
            if (eleccion.ToLower() == "entrar")
            {
                return new FinalBueno();
            }
            else if (eleccion.ToLower() == "regresar")
            {
                return new Inicio();
            }
            else
            {
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                return this;
            }
        }
    }
}
