using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float strength;
    public float maxSpeed;
    private Joystick joy;

	// Use this for initialization
	void Start () {
        joy = GameObject.FindObjectOfType<Joystick>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        float x = joy.Horizontal;
        float z = joy.Vertical;

        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(new Vector3(x, 0, z) * Time.deltaTime * strength);
        }
    }
}
