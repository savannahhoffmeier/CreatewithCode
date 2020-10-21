﻿using System;
using UnityEngine;

public class ChController : MonoBehaviour
{
private Rigidbody playerRb;
public float jumpForce=10;
public float gravityModifier;
public bool isOnGround = true;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
