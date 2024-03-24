using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class interacable : MonoBehaviour
{
    public UnityEvent OnInteract;
    public int ID;
    void Start()
    {
        ID = Random.Range(0, 999999);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
