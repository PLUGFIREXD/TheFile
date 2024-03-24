using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorClose : MonoBehaviour
{
    public DoorScript DoorScript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && DoorScript.Opened == true)
        {
            DoorScript.moved = true;
        }
    }
}
