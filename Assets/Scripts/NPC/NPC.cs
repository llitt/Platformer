using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
   public string startdialogue="Text Goes Here";
   public string completedialogue = "Text Goes Here";
   public ObjectiveType objectiveType;
   public bool completed = false;
   public int seasongoal;
   public GameObject objective;
   public GameObject obstacle,enableobj;
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
      if (objectiveType == ObjectiveType.Collect) {
         if (completed==false&&objective.gameObject.GetComponent<Collectable>().collected==true) {
            UIHandler.uih.diagtext.text = completedialogue;
            startdialogue = completedialogue;
            completed = true;
            obstacle.SetActive(false);
         }
      }
      if (objectiveType == ObjectiveType.ChangeSeason)
      {
         if (LevelManager.LM.timestage==seasongoal)
         {
            UIHandler.uih.dialogui.SetActive(true);
            UIHandler.uih.diagtext.text = completedialogue;
            startdialogue = completedialogue;
            if (enableobj != null)
               enableobj.SetActive(true);
            if (obstacle != null)
               obstacle.SetActive(false);
         }
      }
   }
   private void OnCollisionEnter(Collision collision)
   {
      if (collision.gameObject == objective && objectiveType == ObjectiveType.ReturntoNPC) {
         UIHandler.uih.dialogui.SetActive(true);
         UIHandler.uih.diagtext.text = completedialogue;
         startdialogue = completedialogue;
         if (enableobj != null)
            enableobj.SetActive(true);
         if (obstacle!=null)
            obstacle.SetActive(false);
      }
   }
}
