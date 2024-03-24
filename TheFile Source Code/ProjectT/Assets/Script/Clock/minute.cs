using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minute : MonoBehaviour
{
    public bool minuteCheck;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("minute"))
        {
            minuteCheck = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        minuteCheck = false;
    }
}
