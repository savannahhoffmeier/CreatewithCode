using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public float horizontalInput;
    void Start()
    {
        
    }

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
