using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeId : MonoBehaviour
{
    public int timeId;
   public bool disableonseason = false;
   private void Start()
   {
      TimeDependentObject.TDO.timeDependentObjects.Add(gameObject);  
   }
}
