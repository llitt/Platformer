using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class interact : MonoBehaviour
{
 
   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.tag == "NPC") {
         uihandler.uih.dialogui.SetActive(true);
         uihandler.uih.diagtext.text = other.gameObject.GetComponent<NPC>().startdialogue;
      }
   }
}
