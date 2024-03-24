using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Transform head;
    public float playerSpeed = 5.0f;
    public float playerAcceleration = 2.0f;
    public AudioSource footStep;

    float speed;
    Vector3 oldPosition;

    private Rigidbody rb;
    private Vector3 direction;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        AudioSource footstep = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal") * head.right + Input.GetAxisRaw("Vertical") * head.forward;
        rb.velocity = Vector3.Lerp(rb.velocity, direction * playerSpeed, playerAcceleration * Time.deltaTime);

        if (speed > 3)
        {
            footStep.enabled = true;
        }
        else
        {
            footStep.enabled = false;
        }
    }
    private void FixedUpdate()
    {
        speed = Vector3.Distance(oldPosition,transform.position) * 100f;
        oldPosition = transform.position;

        Debug.Log("Speed: " + speed);
    }
}
