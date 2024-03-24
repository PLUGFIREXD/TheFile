using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorShower : MonoBehaviour
{
    public GameObject moveObj;
    public bool moved, Opened = false;
    [SerializeField] float speed, openangle;
    private float currentangle = 0f;
    public AudioSource AudioSource;
    private void Start()
    {
    }

    public void Interact()
    {
        moved = true;
        Debug.Log("Press");
        StartCoroutine(countdownOpen());
    }


    private void Update()
    {
        if (moved && !Opened)
        {
            if (currentangle <= openangle)
            {
                moveObj.transform.Rotate(0f, speed *-1, 0f);
                currentangle += speed;
                AudioSource.Play();
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
                moveObj.transform.Rotate(0f, speed , 0f);
                currentangle -= speed;
                AudioSource.Play();
            }

            if (currentangle <= 0)
            {
                Opened = false;
                moved = false;
            }

        }
    }
    IEnumerator countdownOpen()
    {
        yield return new WaitForSeconds(30);
        moved = true;
    }
}
