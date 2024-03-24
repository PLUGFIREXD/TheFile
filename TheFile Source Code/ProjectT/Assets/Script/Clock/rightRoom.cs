using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightRoom : MonoBehaviour
{
    public bool isEnter;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isEnter = true;
        }
    }
}
