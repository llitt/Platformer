﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Select : MonoBehaviour
{
   public int TimeId;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnTriggerEnter(Collider other)
   {
      LevelManager.LM.timestage = TimeId;
   }
}
