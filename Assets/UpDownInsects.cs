using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownInsects : MonoBehaviour
{
   Rigidbody rb;
   public GameObject player;
   private GameObject mustHave;
   Vector3 pos;
   public float height, speed;
   bool riding = false;
   int up = 1;
    // Start is called before the first frame update
    void Start()
    {
      Physics.IgnoreLayerCollision(11, 12);
      rb = GetComponent<Rigidbody>();
      pos = rb.position;
      mustHave = GameObject.Find("MUSTPUTINEVERYSCENE");
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


   //  void OnCollisionEnter(Collision collision) {
   //      if(collision.gameObject.tag == "Player"){
   //          collision.collider.transform.SetParent(transform);
   //      }
   //  }

   //  void OnCollisionExit(Collision collision) {
   //     if(collision.gameObject.tag == "Player"){
   //        collision.collider.transform.SetParent(mustHave.transform);
   //     }
   //  }
}
