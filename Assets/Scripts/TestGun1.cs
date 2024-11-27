using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGun1 : MonoBehaviour
{
    private GameObject rhombus;
    private Camera mainCamera;
    private SpriteRenderer _GunRenderer;
    void Start()
    {
        _GunRenderer = GetComponent<SpriteRenderer>();
        transform.SetParent(null);
        rhombus = GameObject.FindGameObjectWithTag("Player");
        mainCamera = Camera.main;
    }

    void Update()
    {
        transform.position = new Vector3(rhombus.transform.position.x, rhombus.transform.position.y-0.3f, rhombus.transform.position.z);
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = transform.position.z; 
        transform.right = mousePos - transform.position;
    }
}
