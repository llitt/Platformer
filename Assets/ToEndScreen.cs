using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToEndScreen : MonoBehaviour
{
   public GameObject winscreen;
   public float timer = 0;
   private bool triggered = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      timer += Time.deltaTime;
      if (timer > 5&&triggered==false) {
         winscreen.SetActive(true);
         triggered = true;
      }
    }
}
