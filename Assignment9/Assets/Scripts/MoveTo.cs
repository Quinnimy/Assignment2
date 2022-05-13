/*
 * Quinn Lamkin
 * Assignment9
 * Move to set object on mesh
 */
using UnityEngine;
using UnityEngine.AI;
public class MoveTo : MonoBehaviour
{
    public Transform goal;
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
}