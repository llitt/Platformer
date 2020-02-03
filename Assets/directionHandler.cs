using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class directionHandler : MonoBehaviour
{
   Animator anim;
   bool rotated = false;
   public Quaternion rot;
    // Start is called before the first frame update
    void Start()
    {
      anim = GetComponent<Animator>();
      rot = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {

      if (anim.GetFloat("moving") > 0 && transform.localRotation == rot && rotated == false)
      {
         rotated = true;
         transform.Rotate(0, 180, 0);
      }
      else if (anim.GetFloat("moving") < 0)
      {
         rotated = false;
         transform.localRotation = rot;
      }
    }
}
