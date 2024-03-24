using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoopManager : MonoBehaviour
{
    public GameObject[] loop;
    public int loopCount;

    void Update()
    {
        if(loopCount > 0)
        {
            loop[loopCount].SetActive(true);
            loop[loopCount - 1].SetActive(false);
        }
    }

}
