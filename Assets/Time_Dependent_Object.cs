using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Dependent_Object : MonoBehaviour
{
   
   public GameObject[] timeDependentObjects;
   // Start is called before the first frame update
   void Start()
    {
        
    }

   // Update is called once per frame
   void Update()
   {
      foreach (GameObject obj in timeDependentObjects) {
         if (LevelManager.LM.timestage != obj.GetComponent<TimeId>().timeId)
         {
            obj.SetActive(false);
         }
         else
            obj.SetActive(true);
      }

   }
}
