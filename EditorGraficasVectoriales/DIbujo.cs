using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorGraficasVectoriales
{
    internal class DIbujo
    {
        public Linea cabeza;

        public DIbujo()
        {
            cabeza = null;
        }

        public void guardar(Linea linea)
        {
            if (linea != null)
            {
                if (cabeza == null)
                {
                    cabeza = linea;
                }
                else
                {
                    Linea apuntator = cabeza;
                    Linea antecesor = null;
                    insertar(linea, antecesor);

                }
            }

        }

        public void insertar(Linea linea, Linea antecesor)
        {
            if (linea != null) 
            {
                if (antecesor == null) 
                {
                    linea.siguiente = cabeza;
                    cabeza = linea;
                }
                else
                {
                    linea.siguiente = antecesor.siguiente;
                    antecesor.siguiente = linea;
                }
            }
        }

        public void mostrar(Graphics e, int i)
        {

            Linea tempo = cabeza;
            while (tempo != null) 
            {
                using (Pen pen = new Pen(Color.White, 2))
                { 
                    switch (tempo.tipo)
                    {
                        case 0:
                            e.DrawLine(pen, tempo.puntoinicial, tempo.puntofinal);
                            break;
                        case 1:
                            e.DrawRectangle(pen, new RectangleF(tempo.puntoinicial,
                                new Size(tempo.puntofinal.X - tempo.puntoinicial.X, tempo.puntofinal.Y - tempo.puntoinicial.Y)));
                            break;
                        case 2:
                            e.DrawEllipse(pen, new RectangleF(tempo.puntoinicial,
                                new Size(tempo.puntofinal.X - tempo.puntoinicial.X, tempo.puntofinal.Y - tempo.puntoinicial.Y)));
                            break;
                    }

                }

                tempo = tempo.siguiente;


            }


        }

       

    }
}
