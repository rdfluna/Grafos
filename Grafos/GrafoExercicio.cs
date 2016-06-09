using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class GrafoExercicio : Grafo
    {
        public GrafoExercicio()
        {
            arestas = new int[8, 8];
            vertices = new int[8];

            PreencherArestas();
            LimparVertices();
        }

        public override void PreencherArestas()
        {
            arestas[0, 0] = 0;
            arestas[0, 1] = 0;
            arestas[0, 2] = 1;
            arestas[0, 3] = 0;
            arestas[0, 4] = 0;
            arestas[0, 5] = 1;
            arestas[0, 6] = 0;
            arestas[0, 7] = 1;

            arestas[1, 0] = 0;
            arestas[1, 1] = 0;
            arestas[1, 2] = 0;
            arestas[1, 3] = 0;
            arestas[1, 4] = 0;
            arestas[1, 5] = 0;
            arestas[1, 6] = 0;
            arestas[1, 7] = 1;

            arestas[2, 0] = 1;
            arestas[2, 1] = 0;
            arestas[2, 2] = 0;
            arestas[2, 3] = 0;
            arestas[2, 4] = 0;
            arestas[2, 5] = 0;
            arestas[2, 6] = 1;
            arestas[2, 7] = 0;

            arestas[3, 0] = 0;
            arestas[3, 1] = 0;
            arestas[3, 2] = 0;
            arestas[3, 3] = 0;
            arestas[3, 4] = 1;
            arestas[3, 5] = 1;
            arestas[3, 6] = 0;
            arestas[3, 7] = 0;

            arestas[4, 0] = 0;
            arestas[4, 1] = 0;
            arestas[4, 2] = 0;
            arestas[4, 3] = 1;
            arestas[4, 4] = 0;
            arestas[4, 5] = 1;
            arestas[4, 6] = 1;
            arestas[4, 7] = 1;

            arestas[5, 0] = 1;
            arestas[5, 1] = 0;
            arestas[5, 2] = 0;
            arestas[5, 3] = 1;
            arestas[5, 4] = 1;
            arestas[5, 5] = 0;
            arestas[5, 6] = 0;
            arestas[5, 7] = 0;

            arestas[6, 0] = 0;
            arestas[6, 1] = 0;
            arestas[6, 2] = 1;
            arestas[6, 3] = 0;
            arestas[6, 4] = 1;
            arestas[6, 5] = 0;
            arestas[6, 6] = 0;
            arestas[6, 7] = 0;

            arestas[7, 0] = 1;
            arestas[7, 1] = 1;
            arestas[7, 2] = 0;
            arestas[7, 3] = 0;
            arestas[7, 4] = 1;
            arestas[7, 5] = 0;
            arestas[7, 6] = 0;
            arestas[7, 7] = 0;
        }
    }
}
