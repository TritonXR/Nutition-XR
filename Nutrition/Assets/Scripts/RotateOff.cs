﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOff : MonoBehaviour {

    private SteamVR_TrackedObject TrackedObject; //= null;
    public SteamVR_Controller.Device Device;

    public Transform plate;
    public Transform plate2;

    void Awake()
    {
        TrackedObject = GetComponent<SteamVR_TrackedObject>();
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //This will check it the controller recieves input 
        Device = SteamVR_Controller.Input((int)TrackedObject.index);

        if (Device.GetTouchDown(SteamVR_Controller.ButtonMask.Grip))
        {
            foreach (Transform child in plate)
            {
                if (child.tag == "Mushroom")
                {
                    child.transform.parent = null;
                }
            }

            foreach (Transform child2 in plate2)
            {
                if (child2.tag == "Garlic")
                {
                    child2.transform.parent = null;
                }
            }
        }


    }
}
