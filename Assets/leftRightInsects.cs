using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftRightInsects : MonoBehaviour
{
   Rigidbody rb;
   Vector3 pos;
   public GameObject player;

   private GameObject mustHave;
   bool riding;
   public float width, speed;
   int right = 1;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
      pos = rb.position;
      mustHave = GameObject.Find("MUSTPUTINEVERYSCENE");
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

      if(riding){
                player.transform.position += new Vector3(0, 0, 0);    
            }
   }


   void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.tag == "Player")
        {
            print("Player is riding the platform!");
            riding = true;
        }
    }
   
    void OnTriggerExit(Collider hit)
    {
        if(hit.gameObject.tag == "Player")
        {
            print("Player is off the paltform =/");
            riding = false;
        }
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Player"){
            collision.collider.transform.SetParent(transform);
        }
    }

    void OnCollisionExit(Collision collision) {
       if(collision.gameObject.tag == "Player"){
          collision.collider.transform.SetParent(mustHave.transform);
       }
    }

}
