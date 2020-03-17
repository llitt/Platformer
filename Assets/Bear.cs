using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
   private Vector3 starpos,goal;
   public float disttopatrol=5f,speed=.3f;
   public GameObject bearsprite;
    void Start()
    {
      starpos = transform.position;
      goal = starpos + new Vector3(0, 0, disttopatrol);
    }

    // Update is called once per frame
    void Update()
    {
      if (Vector3.Distance(transform.position, goal) < 3) {
         disttopatrol = disttopatrol * -1;
         bearsprite.transform.Rotate(new Vector3(0, 180, 0));
         goal = starpos + new Vector3(0, 0, disttopatrol);
      }
      transform.position = Vector3.Lerp(transform.position, goal, Time.deltaTime * speed);
    }
}
