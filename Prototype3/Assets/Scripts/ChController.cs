using System;
using UnityEngine;

public class ChController : MonoBehaviour
{
private Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up*100,ForceMode.Impulse);
        }
    }
}
