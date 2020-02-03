using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveCheckpoint : MonoBehaviour
{
   public Transform cam,parent;
   public Vector3 cammove,offsetwhentriggered;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnTriggerEnter(Collider other)
   {
      if (other.tag == "Player")
      {
         cam.transform.position += cammove;
         parent.position += offsetwhentriggered;
      }
   }
   
}
