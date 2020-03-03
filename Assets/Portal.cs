using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
   public int [] levelForSeason;
   private void OnCollisionEnter(Collision collision)
   {
      SceneManager.LoadScene(levelForSeason[LevelManager.LM.timestage]);
   }
}
