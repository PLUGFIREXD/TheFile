using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class enemyAI : MonoBehaviour
{
    public RayCast RayCast;
    private NavMeshAgent agent;
    public GameObject Player,target;
    public float EnemyDistanceRun , StopDistance;

    float speed;
    Vector3 oldPosition;
    public bool runAway;

    public Animator animator;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        runAway = false;
    }

    // Update is called once per frame
    void Update()
    {

        speed = Vector3.Distance(oldPosition, transform.position) * 100f;
        oldPosition = transform.position;

        Debug.Log("Speed: " + speed);

        if(speed > 1)
        {
            animator.SetBool("isWalk",true);
        }
        else
        {
            animator.SetBool("isWalk", false);
        }

        float distance = Vector3.Distance(transform.position, Player.transform.position);
       // Debug.Log("distance: " + distance);
        if (distance < StopDistance)
        {
            stop();

            if (RayCast.isWatched == true)
            {
                Vector3 dirToPlayer = transform.position - Player.transform.position;

                agent.SetDestination(target.transform.position);

                agent.isStopped = false;

                runAway = true;
            }
        }
        if (distance > StopDistance && runAway == false)
        {
            follow();
        }
    }
   
    void follow()
    {
        agent.SetDestination(Player.transform.position);
        agent.isStopped = false;
    }
    void stop()
    {
        agent.isStopped = true;
    }
}
