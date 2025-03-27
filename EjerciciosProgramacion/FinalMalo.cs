using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacion
{
    public class FinalMalo : Escena
    {
        public override void Mostrar()
        {
            Console.WriteLine("Caíste en una trampa y la aventura ha terminado. Intenta de nuevo.");
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
