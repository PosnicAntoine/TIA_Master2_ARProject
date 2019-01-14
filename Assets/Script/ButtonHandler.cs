using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonHandler : MonoBehaviour , IVirtualButtonEventHandler{

    public GameObject obj;

	// Use this for initialization
	void Start () {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i <vbs.Length; i++)
        {
            vbs[i].RegisterEventHandler(this);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed::" + vb.VirtualButtonName);
        obj.GetComponent<Rigidbody>().isKinematic = false;
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased::" + vb.VirtualButtonName);
    }
}
