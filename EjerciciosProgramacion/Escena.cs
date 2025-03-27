using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacion
{
    public abstract class Escena
    {
        public abstract void Mostrar();
        public abstract Escena TomarDecision(string eleccion);
    }
}