﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(GvrController.TouchDown || Input.GetMouseButton(0))
        {
            //Debug.Log("Hello World!! Gatilho Ativado!!");
            
        }
        
    }
}
