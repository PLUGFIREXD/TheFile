using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameGood : MonoBehaviour
{
    public GameObject fadeOut,endingUI,theThing,runUI;
    public FirstPersonMovement FirstPersonMovement;
    bool ending;

    void Update()
    {
        if(ending == true)
        {
            FirstPersonMovement.enabled = false;
            fadeOut.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        ending = true;
        StartCoroutine(endingScene());
    }
    IEnumerator endingScene()
    {
        yield return new WaitForSeconds(3);
        {
            endingUI.SetActive(true);
            StartCoroutine(restart());
        }
    }
    IEnumerator restart()
    {
        yield return new WaitForSeconds(10);
        {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
