using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    //Line color
    public Color lineColor;
    //List for the Nodes
    private List<Transform> nodes = new List<Transform>();

    // draws the Line
    void OnDrawGizmosSelected()
    {
        //line color
        Gizmos.color = lineColor;
        //Gets the waypoints from the perant compnet
        Transform[] pathTransforms = GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for (int i = 0; i < pathTransforms.Length; i++)
        {
            if (pathTransforms[i] != transform)
            {
                nodes.Add(pathTransforms[i]);
            }
        }
        //draws the line
        for (int i = 0; i < nodes.Count; i++)
        {
            Vector3 currentNode = nodes[i].position;
            Vector3 perviousNode = Vector3.zero;

            if (i > 0)
            {
                perviousNode = nodes[i - 1].position;
            }
            else if(i == 0 && nodes.Count > 1)
            {
                perviousNode = nodes[nodes.Count - 1].position;
            }


            Gizmos.DrawLine(perviousNode, currentNode);
            Gizmos.DrawWireSphere(currentNode, 0.3f);
        }
    }
}





