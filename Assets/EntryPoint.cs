using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
   public GameObject cam,player;
   private bool countdown = false;
   private int timebeforecontrol=1,direction=1;//1 for right -1 for left
   private float timer=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (countdown == true) {
         timer += Time.deltaTime;
         if (timer > timebeforecontrol)
         {
            player.GetComponent<Player>().entryexitmode = false;
            countdown = false;
         }
      }
    }
   private void OnTriggerEnter(Collider other)
   {
      if (player.GetComponent<Player>().entryexitmode == true)
      {
         cam.transform.parent = player.transform;
         countdown = true;
      }
      else {
         player.GetComponent<Player>().entraccedirection = direction;
         player.GetComponent<Player>().entryexitmode = true;
         cam.transform.parent = null;
      }
   }
}
