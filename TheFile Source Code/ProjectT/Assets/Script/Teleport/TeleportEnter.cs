using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TeleportEnter : MonoBehaviour
{
    public GameObject Player, TeleportTo, fadeIn,fadeOut,Hallway;
    IEnumerator waitFade()
    {
        yield return new WaitForSeconds(2);
        Player.transform.position = TeleportTo.transform.position;
        fadeIn.SetActive(true);
        fadeOut.SetActive(false);    
        Hallway.SetActive(true);
    }
    public void teleportConfirm()
    {
        StartCoroutine(waitFade());
    }
}
