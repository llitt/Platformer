using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    private Vector3 startingpos,gatepos;
   public Transform gate;
   public float gateSpeed=.3f,openheight=20;
   private bool down = false;
    void Start()
    {
      startingpos = transform.position;
      gatepos = gate.position;
   }

    // Update is called once per frame
    void Update()
    {
      if (down == false)
      {
         transform.position = startingpos;
         gate.position = Vector3.Lerp(gate.position, gatepos, gateSpeed * Time.deltaTime);
      }
      else {
         gate.transform.position = Vector3.Lerp(gate.transform.position, new Vector3(gatepos.x, gatepos.y + openheight, gatepos.z), gateSpeed * Time.deltaTime);
      }
    }
   private void OnCollisionEnter(Collision collision)
   {
      if ((collision.gameObject.tag=="Player"|| collision.gameObject.tag == "Movable_Object"))
      {
         down = true;
      }
   }
   private void OnCollisionExit(Collision collision)
   {
      if ((collision.gameObject.tag == "Player" || collision.gameObject.tag == "Movable_Object"))
      {
         down = false;
      }
   }

}
