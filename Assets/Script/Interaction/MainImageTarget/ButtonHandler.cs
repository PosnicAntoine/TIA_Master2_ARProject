using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonHandler : MonoBehaviour , IVirtualButtonEventHandler{

    public GameObject objToKinematic;
    public GameObject buttonToAnimate;
    public Vector3 startPosition;

    private Animator anim;

    // Use this for initialization
    void Start () {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i <vbs.Length; i++)
        {
            vbs[i].RegisterEventHandler(this);
        }

        anim = buttonToAnimate.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed::" + vb.VirtualButtonName);
        objToKinematic.GetComponent<Rigidbody>().isKinematic = false;
        objToKinematic.GetComponent<Transform>().position=startPosition;

        anim.SetTrigger("Press");
        
        
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased::" + vb.VirtualButtonName);
    }
}
