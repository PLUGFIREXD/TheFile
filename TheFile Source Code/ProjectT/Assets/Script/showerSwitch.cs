using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showerSwitch : MonoBehaviour
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


    private void Update()
    {
        if (moved && !Opened)
        {
            if (currentangle <= openangle)
            {
                moveObj.transform.Rotate(0f, 0f, speed);
                currentangle += speed;
            }

            if (currentangle >= openangle)
            {
                Opened = true;
                moved = false;
            }

        }
    }
}
