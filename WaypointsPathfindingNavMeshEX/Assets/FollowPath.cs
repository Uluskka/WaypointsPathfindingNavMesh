using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour //Movimentação do objeto.
{
    //Transform goal; // pontos demarcados.
    //float speed = 5.0f; // velocidade do objeto.
    //float accuracy = 1.0f; // Serve para identificar o ponto determinado no mapa para ter a precisão da movimentação e o contorno referente ao ponto.
    //float rotSpeed = 2.0f; // Velocidade de rotação do objeto e suavizar a movimentação da rotação do tank 

    public GameObject wpManager; //array.
    GameObject[] wps; //index.
    UnityEngine.AI.NavMeshAgent agent;
    //GameObject currentNode; // nodes demarcados.
    //int currentWP = 0; // define a origen a ser traçada inicialmente.
    //Graph g; // refencia do scripts criado Graph para completar a tarefa pela unity.

    void Start() // cada waypoint que ele identificar ele irar ter a movimentação desse gerencimento da demarcação dos pontos do array.
                 // identificar o caminho correto que o objeto deve percorrer.
    {
        wps = wpManager.GetComponent<WPManager>().waypoints;
        agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        //wps = wpManager.GetComponent<WPManager>().waypoints;
        //g = wpManager.GetComponent<WPManager>().graph;
        //currentNode = wps[0];
    }
    public void GoToHeli() // Trajetoria para heliporto.
    {
        agent.SetDestination(wps[1].transform.position);
        //g.AStar(currentNode, wps[1]); // algoritimo aplicado dentro do metodo
        //currentWP = 0;
    }
    public void GoToRuin() // Trajetoria para ruinas.
    {
        agent.SetDestination(wps[6].transform.position);
        //g.AStar(currentNode, wps[6]); // algoritimo aplicado dentro do metodo
        //currentWP = 0;
        //currentWP = 0;


    }

    public void casa()
    {
        agent.SetDestination(wps[3].transform.position);
        //g.AStar(currentNode, wps[3]); // algoritimo aplicado dentro do metodo
        //currentWP = 0;
    }
    void LateUpdate()
    {
        /*código utilizado para WAYPOINT
           // Verifica o tamanho do path.
           if (g.getPathLength() == 0 || currentWP == g.getPathLength())
               return; 

           //O nó que estará mais próximo neste momento 
           currentNode= g.getPathPoint(currentWP);


           // se estivermos mais próximo bastante do nó o tanque se moverá para o próximo
           if (Vector3.Distance( // se a distancia do objeto for menor que a de aproximação o objeto ira para o proximo ponto.
               g.getPathPoint(currentWP).transform.position,
               transform.position) < accuracy)
           {
               currentWP++;
           }
           if (currentWP < g.getPathLength())
           {
               goal = g.getPathPoint(currentWP).transform;
               Vector3 lookAtGoal = new Vector3(goal.position.x, // criação do objeto lookAtGoal para dar posicionamento dos eixos x,y,z .
                   this.transform.position.y,
                   goal.position.z);
               Vector3 direction = lookAtGoal - this.transform.position; // serve para fazer uma movimentação para mirar o proximo ponto que o objeto ira percorrer.

               this.transform.rotation = Quaternion.Slerp(this.transform.rotation, // rotação suave do objeto por conta do Quaternion.Slerp.
                   Quaternion.LookRotation(direction),
                   Time.deltaTime * rotSpeed);
           }

           this.transform.Translate(0, 0, speed * Time.deltaTime); //velocidade aplicada no objeto.
       }
        */
    }

}



