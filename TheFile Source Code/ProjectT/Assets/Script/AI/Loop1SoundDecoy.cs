using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Loop1SoundDecoy : MonoBehaviour
{

    public List<Transform> wayPoint;
    NavMeshAgent navMeshAgent;
    public int currentwayPointIndex;

    float speed;
    Vector3 oldPosition;

    public AudioSource footStep;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        walking();

        speed = Vector3.Distance(oldPosition, transform.position) * 100f;
        oldPosition = transform.position;

        if (speed > 1)
        {
            footStep.enabled = true;
        }
        else
        {
            footStep.enabled = false;
        }
    }

    void walking()
    {
        float distanceToWayPoint = Vector3.Distance(wayPoint[currentwayPointIndex].position,transform.position);

        if(distanceToWayPoint <= 5)
        {
            currentwayPointIndex = (currentwayPointIndex + 1);
            StartCoroutine(waitTowalk());
        }
        if(currentwayPointIndex > 5)
        {
            Destroy(gameObject);
        }
    }
    IEnumerator waitTowalk()
    {
        yield return new WaitForSeconds(3);
        navMeshAgent.SetDestination(wayPoint[currentwayPointIndex].position);
    }

}
