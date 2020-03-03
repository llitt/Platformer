﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnTriggerStay(Collider other)
   {
      if (other.tag == "Player") {
         other.GetComponent<Player>().isHiding = true;
      }
   }
   private void OnTriggerExit(Collider other)
   {
      if (other.tag == "Player")
      {
         other.GetComponent<Player>().isHiding = false;
      }
   }
}
