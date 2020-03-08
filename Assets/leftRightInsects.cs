using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftRightInsects : MonoBehaviour
{
   Rigidbody rb;
   Vector3 pos;
   public float width, speed;
   int right = 1;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
      pos = rb.position;
    }

    // Update is called once per frame
    void Update()
    {
      rb.velocity = Vector3.forward * speed* right;
      if (rb.position.z >= (pos.z + width)) {
         right = -1;
      }
      if (rb.position.z <= (pos.z))
      {
         right = 1;
      }
   }
}
