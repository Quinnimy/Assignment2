/*
 * Quinn Lamkin
 * Assignment9
 * Controls the enemy character, makes it pursue player
 */
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
public class EnemyAI : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;

    //pt6
    public GameObject player;
    public float chaseDistance;
    void Start()
    {
        character = GetComponent<ThirdPersonCharacter>();
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;

        //pt6
        player =GameObject.FindGameObjectWithTag("Player");
        chaseDistance = 8.0f;

    }
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                agent.destination = hit.point;
            }
        }*/ //comment out for 6

        MoveEnemy();
    }

    private void MoveEnemy()
    {



        float distanceFromTarget = Vector3.Distance(transform.position, player.transform.position);


        if (distanceFromTarget > agent.stoppingDistance && distanceFromTarget < chaseDistance)
        {
            agent.SetDestination(player.transform.position);
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            agent.SetDestination(transform.position);
            character.Move(Vector3.zero, false, false);
        }
    }
}