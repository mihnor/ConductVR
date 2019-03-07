﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ControllerHighlight : MonoBehaviour
{
    bool inHand = false;
    public SteamVR_Action_Single conduct;
    public Material highlight;
    public HighlightRange range;
    public Transform leftHand, rightHand, leftWrist, rightWrist;
    MeshRenderer baton;
    // Start is called before the first frame update
    void Start()
    {
        baton = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float triggerAxis = conduct.GetAxis(SteamVR_Input_Sources.Any);
        bool holdingTrigger = triggerAxis > 0.1;
        if(!inHand) {
            if(range.InRange_Left()) {
                baton.materials[1] = highlight;
                if(holdingTrigger) {
                    inHand = true;
                    transform.parent.parent = leftWrist;
                    transform.parent.localPosition = Vector3.zero;
                    baton.materials[1] = null;
                    transform.parent.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
            else if(range.InRange_Right()) {
                baton.materials[1] = highlight;
                if(holdingTrigger) {
                    inHand = true;
                    transform.parent.parent = rightWrist;
                    transform.parent.localPosition = Vector3.zero;
                    baton.materials[1] = null;
                    transform.parent.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
            else {                
                baton.materials[1] = null;
            }
        }
        else if(inHand && !holdingTrigger) {
            inHand = false;
            transform.parent.parent = null;
                    transform.parent.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    public bool IsHolding() {
        return inHand;
    }
}
