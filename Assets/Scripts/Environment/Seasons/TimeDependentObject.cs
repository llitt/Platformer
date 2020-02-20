using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDependentObject : MonoBehaviour
{
   public static TimeDependentObject TDO;
   public List<GameObject> timeDependentObjects;
   // Start is called before the first frame update
   void Start()
    {
      TDO = this;
    }

   // Update is called once per frame
   void Update()
   {
      foreach (GameObject obj in timeDependentObjects) {
         if (obj.GetComponent<TimeId>().disableonseason == false)
         {
            if (LevelManager.LM.timestage != obj.GetComponent<TimeId>().timeId)
            {
               obj.SetActive(false);
            }
            else
               obj.SetActive(true);
         }
         else {
            if (LevelManager.LM.timestage != obj.GetComponent<TimeId>().timeId)
            {
               obj.SetActive(true);
            }
            else
               obj.SetActive(false);
         }
      }

   }
}
