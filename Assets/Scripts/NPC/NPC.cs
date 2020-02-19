using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
   public string startdialogue="Text Goes Here";
   public string completedialogue = "Text Goes Here";
   public ObjectiveType objectiveType; 
   public GameObject objective;
   public GameObject obstacle;
   public enum ObjectiveType
   {
      ReturntoNPC,
      Collect,
      Destroy,
      ChangeSeason
   }
   // Update is called once per frame
   void Update()
    {
      if (objective.activeSelf) {

      }
    }
   private void OnCollisionEnter(Collision collision)
   {
      if (collision.gameObject == objective && objectiveType == ObjectiveType.ReturntoNPC) {
         UIHandler.uih.dialogui.SetActive(true);
         UIHandler.uih.diagtext.text = completedialogue;
         startdialogue = completedialogue;
         obstacle.SetActive(false);
      }
   }
}
