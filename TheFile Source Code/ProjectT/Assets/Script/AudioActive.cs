using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioActive : MonoBehaviour
{
    bool isPass;
    public AudioSource AudioSource;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"&&isPass == false)
        {
            AudioSource.Play();
            isPass = true;
        }
    }
}
