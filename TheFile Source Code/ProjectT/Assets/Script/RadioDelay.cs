using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioDelay : MonoBehaviour
{
    public AudioSource AudioSource,AudioSourceDecoy;
    bool isPass = false;
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && isPass == false)
        {
            AudioSourceDecoy.Play();
            StartCoroutine(radio());
            isPass = true;
        }
    }
    IEnumerator radio()
    {
        yield return new WaitForSeconds(90);
        {
            AudioSource.Play();
            Debug.Log("play");
        }
    }
}
