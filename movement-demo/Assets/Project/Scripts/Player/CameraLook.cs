using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float mouseSensitivity = 5f;
    
    [SerializeField] private Transform playerTr;

    private float xRotation = 0f;

    private void Start()
    {
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); 
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        
        playerTr.Rotate(Vector3.up * mouseX);
    }
}
