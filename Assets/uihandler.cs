using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uihandler : MonoBehaviour
{
   public static uihandler uih;
   public GameObject dialogui;
   public TextMeshProUGUI diagtext;
   // Start is called before the first frame update
   void Start()
    {
      uih = this;     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
