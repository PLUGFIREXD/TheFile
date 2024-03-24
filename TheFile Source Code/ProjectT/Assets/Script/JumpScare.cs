using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class JumpScare : MonoBehaviour
{
    public GameObject player,fadeOut;
    public FirstPersonMovement FirstPersonMovement;
    public CameraController CameraController;
    public AIRun AIRun;
    public GameObject jumpScarePos,theThing,ending;
    public float Speed;
    void Start()
    {
        
    }
    void Update()
    {
        if(AIRun.isDied == true)
        {
            transform.position = Vector3.Lerp(transform.position, jumpScarePos.transform.position, Speed * Time.deltaTime);
            FirstPersonMovement.enabled = false;
            theThing.SetActive(false);
            CameraController.enabled = false;
            fadeOut.SetActive(true);
            StartCoroutine(end());
        }
    }
    IEnumerator end()
    {
        yield return new WaitForSeconds(4);
            ending.SetActive(true);
        StartCoroutine(teleport());
    }
    IEnumerator teleport()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
