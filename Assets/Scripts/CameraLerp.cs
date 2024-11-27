using System;
using UnityEngine;

public class CameraLerp : MonoBehaviour
{

    private PlayerMovement _playerMovement;
    private GameObject rhombus;
    private void Start()
    {
        transform.SetParent(null);
        rhombus = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, rhombus.transform.position, 0.4f);
    }
}