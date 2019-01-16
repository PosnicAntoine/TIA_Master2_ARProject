using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float strength;
    private Joystick joy;

	// Use this for initialization
	void Start () {
        joy = GameObject.FindObjectOfType<Joystick>();
	}

    // Update is called once per frame
    void Update() {
        float x = joy.Horizontal;
        float z = joy.Vertical;

        GetComponent<Rigidbody>().AddForce(new Vector3(x, 0, z) * Time.deltaTime * strength);

    }
}
