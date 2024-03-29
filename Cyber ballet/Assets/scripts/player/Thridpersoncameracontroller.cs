﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thridpersoncameracontroller : MonoBehaviour
{
    public float RotationSpeed = 1;
    public Transform target, player;
    float mouseX, mouseY;

   

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    

    void LateUpdate()
    {
        Camcontrol();

    }

    void Camcontrol()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(target);
        target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        player.rotation = Quaternion.Euler(0, mouseX, 0);
    }
}
