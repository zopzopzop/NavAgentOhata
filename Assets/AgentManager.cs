using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;

    void Start()
    {
        //encontra meus agents
       
        agents = GameObject.FindGameObjectsWithTag("ai");
    }


    void Update()
    { 
        //manda o agente para posição em que o mouse foi clicado.
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                foreach (GameObject a in agents)
                a.GetComponent<AiControl>().agent.SetDestination(hit.point);
            }

        }
    }
}
