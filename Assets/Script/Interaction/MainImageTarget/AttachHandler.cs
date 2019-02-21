using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachHandler : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onAttachEvent()
    {
        Debug.Log("couocu");
        GameObject mainObj = GameObject.Find("MainImageTarget");
        if (mainObj != null)
        {
            for (int i = 0; i < transform.childCount; i++) {
                GameObject obj = transform.GetChild(i).gameObject;
                if(obj.layer != 9)
                {
                    Instantiate(obj, mainObj.transform, true);
                }
            }
        }

    }
}
