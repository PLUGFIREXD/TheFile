using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{

    public bool isWatched;

    Camera cam;
    public LayerMask mask;

    void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 100f;
        mousePos = cam.ScreenToWorldPoint(mousePos);
        Debug.DrawRay(transform.position, mousePos - transform.position, Color.blue);

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray,out hit,100,mask))
        {
            Debug.Log(hit.transform.name);
            isWatched = true;
        }
      
    }
}
