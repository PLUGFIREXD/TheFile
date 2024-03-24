using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIRun : MonoBehaviour
{

    public NavMeshAgent enemy;
    public Transform player;

    public bool isDied;
    public GameObject jumpScareScene;
    
    float speed;
    Vector3 oldPosition;

    public AudioSource AudioSource;

    public Animator animator;
    void Update()
    {

        speed = Vector3.Distance(oldPosition, transform.position) * 100f;
        oldPosition = transform.position;

        enemy.SetDestination(player.position);

        if (speed > 1)
        {
            animator.SetBool("isRun", true);
            AudioSource.Play();
        }
        else
        {
            animator.SetBool("isRun", false);
            AudioSource.Stop();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isDied = true;
            jumpScareScene.SetActive(true);
        }
    }

}
