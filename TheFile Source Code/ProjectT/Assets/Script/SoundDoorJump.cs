using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDoorJump : MonoBehaviour
{
    bool isEnter = false;
    public AudioSource AudioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")&&isEnter==false)
        {
            AudioSource.Play();
            isEnter = true;
        }
    }
}
