﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFriction : MonoBehaviour
{
   public float slickness = .03f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnCollisionStay(Collision collision)
   {
      if (collision.gameObject.tag == "Player") {
         collision.gameObject.GetComponent<Player>().celrationSpeed = slickness;
      }
   }
}
