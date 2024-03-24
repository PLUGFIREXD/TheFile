using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareLittle : MonoBehaviour
{
    public GameObject theThing;

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(theThingActive());
        }
    }
    IEnumerator theThingTrigger()
    {
        yield return new WaitForSeconds(0.5f);
        theThing.SetActive(false);
        Destroy(this);
    }
    IEnumerator theThingActive()
    {
        yield return new WaitForSeconds(1f);
        theThing.SetActive(true);
        StartCoroutine(theThingTrigger());
    }
}
