using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorGraficasVectoriales
{
    public class Linea
    {
        public Point puntoinicial;
        public Point puntofinal;
        public int tipo;
        public Linea siguiente;

        public Linea(Point puntoIn, Point puntoFi, int tipo)
        {
            this.puntoinicial = puntoIn;
            this.puntofinal = puntoFi;
            this.tipo = tipo;
        }
    }
}
