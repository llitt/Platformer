using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2_2Pyramid : MonoBehaviour
{
    public static bool cutscene=false;
   private Vector3 currentLoc;
   public Transform refernce;
    void Start()
    {
      currentLoc = transform.position;
      transform.position = new Vector3(transform.position.x, refernce.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
      if (cutscene) {
         transform.position = Vector3.Lerp(transform.position, currentLoc, 1 * Time.deltaTime);
      }
    }
}
