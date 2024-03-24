using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairLookAt : MonoBehaviour
{

    public GameObject[] chairs;
    public Transform target;
    public int chairCount;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // chair[chairCount].transform.LookAt(target.transform);
    }
    public void isSit()
    {
        foreach(GameObject Chair in chairs)
        {
            Chair.transform.LookAt(target);
        }
    }
}
