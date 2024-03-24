using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneLoad : MonoBehaviour
{
    public GameObject Volume,entrance,hallway,fadeIn,fadeOut;
    public FirstPersonMovement FirstPersonMovement;
    void Start()
    {
        Volume.SetActive(true);
        entrance.SetActive(false);
        hallway.SetActive(false);
        FirstPersonMovement.enabled = false;
        StartCoroutine(fadeDis());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator fadeDis()
    {
        yield return new WaitForSeconds(3);
        fadeIn.SetActive(false);
    }
}
