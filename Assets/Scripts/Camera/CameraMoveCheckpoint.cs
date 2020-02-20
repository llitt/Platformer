using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveCheckpoint : MonoBehaviour
{
   public Transform cam,parent;
   public float heighttoFloor=16;
   public Vector3 cammove,offsetwhentriggered;
    // Start is called before the first frame update
    void Start()
    {
      GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnTriggerEnter(Collider other)
   {
      if (other.tag == "Player")
      {
         LevelManager.LM.respawnpoint = transform.position+(Vector3.down*heighttoFloor);
         cam.transform.position += cammove;
         parent.position += offsetwhentriggered;
      }
   }
   
}
