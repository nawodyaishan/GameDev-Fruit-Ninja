using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        SetBladeToMouse();
    }

    void SetBladeToMouse()
    {
        var mousePosition = Input.mousePosition;

        mousePosition.z = 10; // distance of 10 units from camera

        // Input should be in the mouse position
        _rigidbody2D.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }
}