using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest_Tracker_Check : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      if (Quest_Tracker.qT.numofQuestsCompleted == Quest_Tracker.qT.numofQuests) {
         GetComponent<Button>().interactable = true;
      }
      else
         GetComponent<Button>().interactable = false;
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
