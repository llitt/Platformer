using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
   float timer;
   public float timebeforeffect = .2f;
   public Vector3 direction=Vector3.up;
   // Start is called before the first frame update
   private void OnTriggerStay(Collider other)
   {
      timer += Time.deltaTime;
      if (timer>timebeforeffect)
         other.gameObject.GetComponent<Rigidbody>().velocity= other.gameObject.GetComponent<Rigidbody>().velocity+direction*Time.deltaTime;
   }
   private void OnTriggerExit(Collider other)
   {
      timer = 0;
   }
}
