﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movemntSpeed;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("w"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movemntSpeed * 2.5f;
        }else if (Input.GetKey("w") && !Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movemntSpeed;
        }
        else if (Input.GetKey("s"))
        {
            transform.position += transform.TransformDirection(Vector3.back) * Time.deltaTime * movemntSpeed;
        }

        if(Input.GetKey("a") && !Input.GetKey("d"))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movemntSpeed;
        } else if(Input.GetKey("d") && !Input.GetKey("a"))
        {
            transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * movemntSpeed;
        }
    }
}
