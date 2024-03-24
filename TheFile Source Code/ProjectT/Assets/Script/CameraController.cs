using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform _camera;
    public Transform hand;
    public float cameraSensitivity = 200f;
    public float cameraAcceleration = 5.0f;

    private float rotation_x_axis;
    private float rotation_y_axis;
    private float flashlightRotation;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        rotation_x_axis += Input.GetAxisRaw("Mouse Y") * cameraSensitivity * Time.deltaTime;
        rotation_y_axis += Input.GetAxisRaw("Mouse X") * cameraSensitivity * Time.deltaTime;
        flashlightRotation += Input.GetAxisRaw("Mouse X") * cameraSensitivity * Time.deltaTime;

        rotation_x_axis = Mathf.Clamp(rotation_x_axis, -90, 90);
        flashlightRotation = Mathf.Clamp(flashlightRotation, -30, 30 );

        hand.localRotation = Quaternion.Euler(-rotation_x_axis, flashlightRotation, 0);

        transform.localRotation = Quaternion.Lerp(transform.localRotation,Quaternion.Euler(0,rotation_y_axis,0),cameraAcceleration * Time.deltaTime);

        _camera.localRotation = Quaternion.Lerp(_camera.localRotation, Quaternion.Euler(-rotation_x_axis, 0, 0), cameraAcceleration * Time.deltaTime); 
    }
}
