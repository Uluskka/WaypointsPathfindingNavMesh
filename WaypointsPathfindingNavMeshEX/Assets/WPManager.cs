using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable] //distribuição de Informações para diferentes tipo de classe.
public struct Link // Construção de links de conexões de um ponto ao outro.
{
    public enum direction { UNI, BI } // UNI=Trajetória de ida BI= ida e volta.
    public GameObject node1; //Trajetória que o tank faz para point 1
    public GameObject node2; //Trajetória que o tank faz para point 2.
    public direction dir;    //Direção que o tank ira seguir.

}
public class WPManager : MonoBehaviour //gerenciamento de waypoint
{
    //array de Informações
    public GameObject[] waypoints;
    public Link[] links;
    public Graph graph = new Graph();


    void Start()
    {   //declaração do tamanho da contrução do projeto.
        if (waypoints.Length > 0) //condição maior que zero para que posso se deslocar do lugar e verificando os pontos implementado no projeto maior que 0.
        {
            foreach (GameObject wp in waypoints) // O Comando funciona na ideia de ser um loop para completar o array criado.
            {
                graph.AddNode(wp);
                {
                    foreach (Link l in links) // Comando para conectar os pontos entre si.
                    {
                        graph.AddEdge(l.node1, l.node2); // Serve para conectar os node vulgo arestas.
                        if (l.dir == Link.direction.BI) // para saber se ele possuie 2 sentidos (ida e volta) dentro da aresta.
                            graph.AddEdge(l.node2, l.node1); // volta para o ponto de origem.

                    }
                }
            }
        }


        
    }
    void Update()
    {
        graph.debugDraw(); // Traçar a rota que o tank realizará entre os points.
    }
}
