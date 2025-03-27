using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacion
{
    public class FinalBueno : Escena
    {
        public override void Mostrar()
        {
            Console.WriteLine("¡Felicidades! Has encontrado la salida del bosque y sobreviviste a la aventura.");
        }

        public override Escena TomarDecision(string eleccion)
        {
            Console.WriteLine("¿Quieres jugar de nuevo? (si/no)");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta == "si")
            {
                return new Inicio();
            }
            else
            {
                return null; 
            }
        }
    }
}
