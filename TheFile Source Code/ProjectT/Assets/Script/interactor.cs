using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interactor : MonoBehaviour
{
    public LayerMask interactableLayermask = 3;
    public interacable interacable;
    public GameObject interactorText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward,out hit,2,interactableLayermask))
        {
            interactorText.SetActive(true);
            if(hit.collider.GetComponent<interacable>()!= false )
            {
                if(interacable == null || interacable.ID != hit.collider.GetComponent<interacable>().ID)
                {
                    interacable = hit.collider.GetComponent<interacable>();
                }
                if(Input.GetKeyDown(KeyCode.F))
                {
                    interacable.OnInteract.Invoke();
                }
            }
        }
        else
        {
            interactorText.SetActive (false);
        }
    }
}
