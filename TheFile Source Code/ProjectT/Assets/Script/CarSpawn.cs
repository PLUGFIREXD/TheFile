using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject carPrefab;
    [SerializeField]float timer, timeSpawn;
    void Start()
    {
        timer = 60;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeSpawn)
        {
            Instantiate(carPrefab, transform.position, Quaternion.identity);
            timer = 0;
        }
    }
}
