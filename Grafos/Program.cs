using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafo grafoExercicio = new GrafoExercicio();

            Console.WriteLine("Exibindo Grafo em Matriz de Adjacência do Exercicio");
            grafoExercicio.ExibirGrafo();
            Console.WriteLine("\n");

            Processar(grafoExercicio);

            Console.ReadLine();
        }

        static void Processar(Grafo grafo)
        {
            Console.WriteLine("Busca em profundidade (DFS)");
            for (int i = 0; i < grafo.vertices.Length; i++)
            {
                ProcessarDFS(grafo, i);
            }

            grafo.LimparVertices();

            Console.WriteLine("\n");
            Console.WriteLine("Busca em largura (BFS)");
            ProcessarBFS(grafo);
        }

        static void ProcessarDFS(Grafo grafo, int vertices)
        {
            grafo.vertices[vertices] = 1;
            for (int i = 0; i < grafo.arestas.GetLength(0); i++)
            {
                if (grafo.vertices[i] == 0 && grafo.arestas[vertices, i] == 1)
                {
                    Console.Write("Aresta da vertice " + vertices + " até a vertice " + i + "\n");
                    ProcessarDFS(grafo, i);
                }
            }
        }

        static void ProcessarBFS(Grafo grafo)
        {
            List<int> fila = new List<int>();
            fila.Add(0);

            //visitado
            grafo.arestas[0] = 1;

            while(fila[i] )

            for (int i = 0; i < grafo.arestas.GetLength(0); i++)
            {
                grafo.vertices[i] = 2;
                if (grafo.vertices[j] != 2 && grafo.arestas[i, j] == 1)
                {
                    Console.Write("Aresta da vertice " + i + " até a vertice " + j + "\n");
                    grafo.vertices[j] = 1;
                }
            }
        }



    }
}
