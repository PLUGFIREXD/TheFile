using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public GameObject flashLight;
    bool turnLight;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            turnLight = !turnLight;
        }

        if (turnLight == true)
        {
            flashLight.SetActive(true);
        }
        else
        {
            flashLight.SetActive(false);
        }

    }
}
