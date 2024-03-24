using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.Translate(Vector3.left * 10 * Time.deltaTime);
        if(timer > 30)
        {
            Destroy(gameObject);
        }
    }
}
