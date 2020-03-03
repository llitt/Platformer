using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawnable : MonoBehaviour
{
   Vector3 originpos;
   Quaternion originrot;
    // Start is called before the first frame update
    void Start()
    {
      originpos = transform.position;
      originrot = transform.rotation;
    }

   // Update is called once per frame
   public void resetpos() {
      transform.position = originpos;
      transform.rotation = originrot;
   }
}
