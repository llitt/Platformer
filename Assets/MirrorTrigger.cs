using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorTrigger : MonoBehaviour
{
   public int mirrortriggerid;
   private void OnTriggerStay(Collider other)
   {
      if (other.tag=="Mirror")
         LightPuzzel.LP.mirrorsinplace[mirrortriggerid] = true;
   }
   private void OnTriggerExit(Collider other)
   {
      if (other.tag == "Mirror")
         LightPuzzel.LP.mirrorsinplace[mirrortriggerid] = false;
   }
}
