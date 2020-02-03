using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWheel : MonoBehaviour
{
   private float deltatime,lasttime;
   public float rotspeed=5f;
    // Start is called before the first frame update
    void Start()
    {
      lasttime = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
      deltatime = Time.realtimeSinceStartup - lasttime;
      lasttime = Time.realtimeSinceStartup;
      float xmov = Input.GetAxis("Mouse X");
      if (xmov != 0) {
         transform.Rotate(xmov* deltatime * rotspeed, 0, 0);
      }
    }
}
