using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBox : MonoBehaviour
{
   float timer=0;
    // Start is called before the first frame update
    void OnEnable()
    {
      timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
      timer += Time.fixedUnscaledDeltaTime;
      if (timer>3)
         gameObject.SetActive(false);
    }
}
