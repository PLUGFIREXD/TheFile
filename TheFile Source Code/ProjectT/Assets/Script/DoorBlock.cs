using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBlock : MonoBehaviour
{

    public PickUp PickUp;
    public GameObject crowbarAnim;
    public void destroyWood()
    {
       if(PickUp.canDestroy == true)
        {
            StartCoroutine(destroyAnim());
            crowbarAnim.SetActive(true);
        }
    }
    IEnumerator destroyAnim()
    {
        yield return new WaitForSeconds(0.8f);
        Destroy(gameObject);
        crowbarAnim.SetActive(false);

    }
}
