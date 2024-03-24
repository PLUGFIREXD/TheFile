using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{

    public MovementController MovementController;
    public CameraController CameraController;
    public Transform PickPosition,PickRotation;

    bool isPickup = false;
    float speed = 2;

    public void Update()
    {
        if(isPickup == true)
        {
            transform.position = Vector3.Lerp(transform.position, PickPosition.position, speed * Time.deltaTime);
            transform.LookAt(PickRotation);           
        }
    }

    public void PickUp()
    {
        isPickup = true;
        //StartCoroutine(StopFollow());
        Debug.Log("isPick");
    }
    IEnumerator StopFollow()
    {
        yield return new WaitForSeconds(3);
        isPickup = false;
    }
}
