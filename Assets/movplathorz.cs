using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movplathorz : MonoBehaviour
{
   public float timer = 0f;
   public float timebeforechange = 3f;
   public GameObject beetlesprite;
   private Rigidbody rb,rbtomove;
   bool moveother=false;
   private void Start()
   {
      rb = GetComponent<Rigidbody>();
   }
   void Update()
    {
      timer += Time.deltaTime;
      if (timer < timebeforechange)
      {
         rb.velocity = new Vector3(0, 0, 6f);
         beetlesprite.transform.localRotation=Quaternion.Euler(0, 90, 0);
      }
      else if (timer < timebeforechange*2)
      {
         rb.velocity = new Vector3(0, 0, -6f);
         beetlesprite.transform.localRotation = Quaternion.Euler(0, -90, 0);
      }
      else
         timer = 0;
    }
   private void FixedUpdate()
   {
      if (moveother) {
         if (Input.GetAxisRaw("Horizontal")!=0)
         {
            rbtomove.velocity = new Vector3(rbtomove.velocity.x, rbtomove.velocity.y, rbtomove.velocity.z + rb.velocity.z);
         }
         else
            rbtomove.velocity = new Vector3(rbtomove.velocity.x, rbtomove.velocity.y, rb.velocity.z);
      }
   }
   private void OnCollisionStay(Collision collision)
   {
      rbtomove = collision.gameObject.GetComponent<Rigidbody>();
      moveother = true;
   }
   private void OnCollisionExit(Collision collision)
   {
      rbtomove = null;
      moveother = false;
   }
}
