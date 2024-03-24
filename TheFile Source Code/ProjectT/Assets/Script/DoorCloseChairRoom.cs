using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCloseChairRoom : MonoBehaviour
{
    public DoorScript DoorScript;
    bool isPass;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && DoorScript.Opened == true && isPass == false)
        {
            DoorScript.moved = true;
            isPass = true;
        }
    }
}
