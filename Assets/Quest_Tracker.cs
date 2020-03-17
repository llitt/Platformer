using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_Tracker : MonoBehaviour
{
   public static Quest_Tracker qT;
   public int numofQuestsCompleted = 0;
   public int numofQuests = 2;
    void Start()
    {
      DontDestroyOnLoad(gameObject);
      qT = this;
    }

}
