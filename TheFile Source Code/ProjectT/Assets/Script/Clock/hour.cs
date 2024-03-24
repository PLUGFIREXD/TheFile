using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hour : MonoBehaviour
{
    public bool hourCheck = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("hour"))
        {
            hourCheck = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        hourCheck = false;
    }
}
