using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2_2Plate : MonoBehaviour
{
   private Vector3 startingpos;
   public GameObject cam,cutscenecam;
   public GameObject pl;
   public float timer = 0f;
   private bool down = false;
   void Start()
   {
      startingpos = transform.position;
   }

   // Update is called once per frame
   void Update()
   {
      if (down == false)
      {
         transform.position = startingpos;

      }
      else
      {
         L2_2Pyramid.cutscene = true;
         if (timer < 4)
         {
            pl.SetActive(false); ;
            cam.SetActive(false);
            cutscenecam.SetActive(true);
            timer += Time.deltaTime;
         }
         else
         {
            pl.SetActive(true); 
            cam.SetActive(true);
            cutscenecam.SetActive(false);
         }
      }
   }
   private void OnCollisionEnter(Collision collision)
   {
      if ((collision.gameObject.tag == "Player" || collision.gameObject.tag == "Movable_Object"))
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
