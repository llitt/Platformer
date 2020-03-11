using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
   public GameObject cam,player;
   private bool countdown = false;
   private int timebeforecontrol=1;
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
            player.GetComponent<Player>().entryexitmode = false;
      }
    }
   private void OnTriggerEnter(Collider other)
   {
      cam.transform.parent = player.transform;
      countdown = true;
   }
}
