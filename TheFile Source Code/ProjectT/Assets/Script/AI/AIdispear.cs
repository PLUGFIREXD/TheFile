using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIdispear : MonoBehaviour
{
    public GameObject enemy;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Destroy(enemy);
        }
    }
}
