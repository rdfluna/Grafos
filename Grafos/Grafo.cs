using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public abstract class Grafo
    {
        public int[,] arestas { get; set; }
        public int[] vertices { get; set; }

        public abstract void PreencherArestas();

        public void LimparVertices()
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i] = 0;
            }
        }

        public void ExibirGrafo()
        {
            for (int i = 0; i < arestas.GetLength(0); i++)
            {
                for (int j = 0; j < arestas.GetLength(1); j++)
                {
                    Console.Write(arestas[i, j] + " ");
                }
                Console.Write("\r\n");
            }
        }
    }
}
