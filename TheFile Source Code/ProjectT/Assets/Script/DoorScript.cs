using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject moveObj;
    public bool moved, Opened = false;
    [SerializeField] float speed, openangle;
    private float currentangle = 0f;
    public void Interact()
    {
        moved = true;
        Debug.Log("Press");
    }
    void Start()
    {
        speed = 1 + speed * Time.deltaTime;
    }
    private void Update()
    {


        if (moved && !Opened)
        {
            if (currentangle <= openangle)
            {
                moveObj.transform.Rotate(0f, speed, 0f);
                currentangle += speed;
            }

            if (currentangle >= openangle)
            {
                Opened = true;
                moved = false;
            }

        }

        if (moved && Opened)
        {
            if (currentangle >= 0)
            {
                moveObj.transform.Rotate(0f, speed * -1, 0f);
                currentangle -= speed;
            }

            if (currentangle <= 0)
            {
                Opened = false;
                moved = false;
            }

        }


    }
}
