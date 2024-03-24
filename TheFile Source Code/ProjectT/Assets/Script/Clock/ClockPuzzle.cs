using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockPuzzle : MonoBehaviour
{
    GameObject Clock;
    public GameObject Hour,Minute,loopPass,qeUI;
    [SerializeField] float speed, angle;
    public minute minute;
    public hour hour;
    bool isCheck;
    float currentAngle;
    public AudioSource AudioSource;
    void Start()
    {
        Clock = GetComponent<GameObject>();
    }
    void Update()
    {
        int holdLayer = LayerMask.NameToLayer("holdLayer");
        if(gameObject.layer == holdLayer)
        {
            qeUI.SetActive(true);
            if(Input.GetKey(KeyCode.Q))
            {
                Hour.transform.Rotate(-speed, 0f, 0f);
                currentAngle += speed;
            }
            if (Input.GetKey(KeyCode.E))
            {
                Minute.transform.Rotate(-speed, 0f, 0f);
                currentAngle += speed;
            }
        }
        if(minute.minuteCheck == true && hour.hourCheck == true && isCheck == false)
        {
            loopPass.SetActive(false);
            AudioSource.Play();
            isCheck = true;
        }
    }
}
