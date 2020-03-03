using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownPlatform : MonoBehaviour
{
   Rigidbody rb;
   Vector3 pos;
   public float height=3, speed=.5f;
   int up = 1;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
      pos = rb.position;
    }

    // Update is called once per frame
    void Update()
    {
      rb.velocity = Vector3.up * speed*up;
      if (rb.position.y >= (pos.y + height)) {
         up = -1;
      }
      if (rb.position.y <= (pos.y))
      {
         up = 1;
      }
   }
}
