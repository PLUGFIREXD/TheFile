using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AILooking : MonoBehaviour
{
    public GameObject moveObj;
    public bool moved, Opened = false;
    [SerializeField] float speed, openangle;
    private float currentangle = 0f;

    public RayCast rayCast;
    public void Interact()
    {
        moved = true;
        Debug.Log("Press");
    }


    private void Update()
    {
        if(rayCast.isWatched == true)
        {
            moved = true;
        }
        if (moved && !Opened)
        {
            if (currentangle <= openangle)
            {
                moveObj.transform.Rotate(0f, 0f, speed);
                currentangle += speed;
                StartCoroutine(dispaear());
            }

            if (currentangle >= openangle)
            {
                Opened = true;
                moved = false;
            }
        }
    }
    IEnumerator dispaear()
    {
        yield return new WaitForSeconds(1);
        Destroy(moveObj);
    }
}
