using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
   float timer;
   bool fly=false;
   public float timebeforeffect = .2f;
   public Vector3 direction=Vector3.up;
   // Start is called before the first frame update
   private void Update()
   {
      if (fly == true)
      {
         timer += Time.deltaTime;
      }
   }
   private void FixedUpdate()
   {
      if (timer > timebeforeffect)
      {
         Player.player.GetComponent<Rigidbody>().velocity = new Vector3(0, direction.y*Time.deltaTime + Player.player.GetComponent<Rigidbody>().velocity.y, direction.z * Time.deltaTime + Player.player.GetComponent<Rigidbody>().velocity.z);
      }
   }
   private void OnTriggerStay(Collider other)
   {
      fly = true;
   }
   private void OnTriggerExit(Collider other)
   {
      fly = false;
      other.GetComponent<Rigidbody>().velocity = Vector3.zero;
      timer = 0;
   }
}
