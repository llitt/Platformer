using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPuzzel : MonoBehaviour
{
   public bool[] mirrorsinplace= {false,false,false};
   public GameObject[] lights;
   public GameObject gate;
   public static LightPuzzel LP;
   // Update is called once per frame
   private void Start()
   {
      LP = this;
   }
   void Update()
    {
      if (mirrorsinplace[0] && mirrorsinplace[1] && mirrorsinplace[2] && LevelManager.LM.timestage == 3)
      {
         lights[2].SetActive(true);
         lights[0].SetActive(false);
         lights[1].SetActive(false);
         lights[3].SetActive(false);
         Destroy(gate);
      }
      else if (mirrorsinplace[0] && mirrorsinplace[1] && LevelManager.LM.timestage == 3)
      {
         lights[2].SetActive(false);
         lights[0].SetActive(false);
         lights[1].SetActive(true);
         lights[3].SetActive(false);
      }
      else if (mirrorsinplace[0] && LevelManager.LM.timestage == 3)
      {
         lights[2].SetActive(false);
         lights[0].SetActive(true);
         lights[1].SetActive(false);
         lights[3].SetActive(false);
      }
      else if (LevelManager.LM.timestage == 3)
      {
         lights[2].SetActive(false);
         lights[0].SetActive(false);
         lights[1].SetActive(false);
         lights[3].SetActive(true);
      }
      else {
         lights[2].SetActive(false);
         lights[0].SetActive(false);
         lights[1].SetActive(false);
         lights[3].SetActive(false);
      }

   }
}
