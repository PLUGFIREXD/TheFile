using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TeleportStartGame : MonoBehaviour
{
    public GameObject Player, TeleportTo, fadeIn,fadeOut,Entrance,StartMenu,FlashLight;
    public FirstPersonMovement FirstPersonMovement;
    IEnumerator waitFade()
    {
        yield return new WaitForSeconds(2);
        Player.transform.position = TeleportTo.transform.position;
        FirstPersonMovement.enabled = true;
        fadeIn.SetActive(true);
        fadeOut.SetActive(false);    
        Entrance.SetActive(true);
        StartMenu.SetActive(false);
        FlashLight.SetActive(true);
    }
    public void teleportConfirm()
    {
        StartCoroutine(waitFade());
    }
}
