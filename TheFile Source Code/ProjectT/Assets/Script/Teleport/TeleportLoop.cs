using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TeleportLoop : MonoBehaviour
{
    public Transform Player;
    public Transform TeleportTo;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player.transform.position = new Vector3(Player.position.x, TeleportTo.position.y, Player.position.z);
            Physics.SyncTransforms();
        }
    }
}
