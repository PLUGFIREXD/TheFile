using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopCheck : MonoBehaviour
{
    public GameLoopManager GameLoopManager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameLoopManager.loopCount += 1;
        }
    }
}
