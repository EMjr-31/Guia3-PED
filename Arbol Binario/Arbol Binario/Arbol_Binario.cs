using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using System.Threading;

namespace Arbol_Binario
{
    class Arbol_Binario
    {
        public Nodo_Arbol Raiz;
        public Nodo_Arbol aux;
        public Arbol_Binario()
        {
            aux = new Nodo_Arbol();
        }
        public Arbol_Binario(Nodo_Arbol nueva_raiz)
        {
            Raiz = nueva_raiz;
        }
        // Función para agregar un nuevo nodo (valor) al Árbol Binario.
        public void Insertar(int x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
                Raiz.nivel = 0;
            }
            else
            {
                Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel);
            }
        }
        // Función para eliminar un nodo (valor) del Árbol Binario.
        public void eliminar(int x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
            }
            else
            {
                Raiz.Elimimar(x, ref Raiz);
            }
        }
        //Función para buscar 
        public void Buscar(int x)
        {
            Raiz.Buscar(x, Raiz);
        }

        //Función para dibujar árbol binario en el formulario
        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            int x = 400;
            int y = 75;
            if (Raiz == null)
                return;
            Raiz.PosicionNodo(ref x, y);
            Raiz.DibujarRamas(grafo, Lapiz);
            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
        }
        //Posiciones iniciales de la raíz del árbol
        public int x1 = 40;
        public int y1=75;
        // Función para Colorear los nodos
        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Nodo_Arbol Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Red;
            if (inor == true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar  1000 milisegundos
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);

                }
                else
                {
                    if (preor == true)
                    {
                        if (Raiz != null)
                        {
                            Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                            Thread.Sleep(1000); // pausar  1000 milisegundos
                            Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                            colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, post);
                            colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, post);

                        }
                    }
                    else{
                        if (post == true)
                        {
                            colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                            colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                            Thread.Sleep(1000); // pausar  1000 milisegundos
                            Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                        }
                    }
                }
            }
        }
    }

}
