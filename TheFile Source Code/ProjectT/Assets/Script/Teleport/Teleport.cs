using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Player;
    public GameObject TeleportTo;
   
    public void teleportConfirm()
    {
        Player.transform.position = TeleportTo.transform.position;
    }
}
