using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorPuzzle : MonoBehaviour
{
    public leftRoom leftRoom;
    public rightRoom rightRoom;
    public DoorScript doorScriptLeft,doorScriptRight;

    private void Update()
    {
        if(leftRoom.isEnter == true && rightRoom.isEnter == true)
        {
            doorScriptLeft.enabled = true;
            doorScriptRight.enabled = true;
        }
    }
}
