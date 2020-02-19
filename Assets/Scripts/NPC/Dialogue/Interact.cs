using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Interact : MonoBehaviour
{
 
   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.tag == "NPC") {
         UIHandler.uih.dialogui.SetActive(true);
         UIHandler.uih.diagtext.text = other.gameObject.GetComponent<NPC>().startdialogue;
      }
   }
}
