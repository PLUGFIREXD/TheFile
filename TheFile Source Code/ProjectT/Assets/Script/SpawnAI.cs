using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnAI : MonoBehaviour
{
    public GameObject GameObject,runUI;
    public FirstPersonMovement FirstPersonMovement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.SetActive(true);
            FirstPersonMovement.canRun = true;
            runUI.SetActive(true);
            StartCoroutine(runUIShow());
        }
        
    }
    IEnumerator runUIShow()
    {
        yield return new WaitForSeconds(3);
        runUI.SetActive(false);
    }
}
