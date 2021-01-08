﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 30;
    public float horizontalInput;
    public float verticalInput;
    private int xRange = 20;
    public GameObject flyFood;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        //limit bound
        if (transform.position.x < -xRange) // too left
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange) // too right
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Generate fly food
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(flyFood, transform.position, flyFood.transform.rotation);
        }
    }
}
