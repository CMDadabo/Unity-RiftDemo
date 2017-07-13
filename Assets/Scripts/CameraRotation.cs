using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    private Camera camera;

    // Use this for initialization
    void Start()
    {
        camera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotationSpeed = 10f;
        Quaternion xRotation = Quaternion.Euler(0, Input.GetAxis("Mouse X") * rotationSpeed, 0);
        Quaternion yRotation = Quaternion.Euler(-Input.GetAxis("Mouse Y") * rotationSpeed, 0, 0);

        transform.localRotation = transform.localRotation * xRotation;
        camera.transform.localRotation = camera.transform.localRotation * yRotation;
    }
}
