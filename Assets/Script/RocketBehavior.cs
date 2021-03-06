﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBehavior : MonoBehaviour
{

    public bool isFiring;
    public float acceleration;
    public float maxSpeed;
    public float rotAccelleration;
    public float rotnMaxSpeed;
    public float firingCounter;


    private Transform t;
    private float speed = 0;
    private float rotSpeed = 0;
    private float currentCounter = 0;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
        audioSource = this.GetComponent<AudioSource>();
        audioSource.Stop();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isFiring)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }

            if (firingCounter < currentCounter)
            {
                t.Translate(0, speed * Time.deltaTime, 0);
                t.Rotate(0, rotSpeed * Time.deltaTime, 0);

                if (speed < maxSpeed)
                {
                    speed = speed + (acceleration * Time.deltaTime);
                }
                if (rotSpeed < rotnMaxSpeed)
                {
                    rotSpeed = rotSpeed + (rotAccelleration * Time.deltaTime);
                }
            }
            else
            {
                currentCounter = currentCounter + Time.deltaTime;
            }
        }
    }
}
