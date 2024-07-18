using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTeleporter : MonoBehaviour
{
    public Transform cameraDestination;  // Destination where the camera should be teleported to
    private GameObject mainCamera;

    private void Awake()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TeleportCamera();
        }
    }

    private void TeleportCamera()
    {
        mainCamera.transform.position = cameraDestination.position;
        mainCamera.transform.rotation = cameraDestination.rotation;
        Debug.Log("Camera Teleported");
    }
}

