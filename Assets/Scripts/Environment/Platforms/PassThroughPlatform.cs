using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassThroughPlatform : MonoBehaviour
{
   public bool groundedontouch=true;
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
      Player.player.grounded = groundedontouch;
   }
}
