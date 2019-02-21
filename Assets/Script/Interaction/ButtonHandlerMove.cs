using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonHandlerMove : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject objToMove;
    public Vector3 vectorMovement;

    public GameObject buttonToAnimate;

    private Animator anim;

    // Use this for initialization
    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponents<VirtualButtonBehaviour>();

        for (int i = 0; i < vbs.Length; i++)
        {
            vbs[i].RegisterEventHandler(this);
        }

        anim = buttonToAnimate.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed::" + vb.VirtualButtonName);
        objToMove.GetComponent<Transform>().Translate(this.vectorMovement);

        anim.SetTrigger("Press");


    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased::" + vb.VirtualButtonName);
    }
}
