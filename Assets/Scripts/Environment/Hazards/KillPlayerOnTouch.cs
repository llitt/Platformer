﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerOnTouch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnCollisionEnter(Collision collision)
   {
      if (collision.gameObject.tag == "Player") {
         collision.gameObject.GetComponent<Player>().player_DIE();
      }
      else if (collision.gameObject.tag == "Movable_Object")
      {
         collision.gameObject.GetComponent<Respawnable>().resetpos();
      }
   }
}
