using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeDangerZone : MonoBehaviour
{
   public Bee bee;
   public bool ignoreenemylayer=false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnTriggerStay(Collider other)
   {
      if (other.tag == "Player" || (other.tag == "Enemy" && ignoreenemylayer == false))
      {
         if (other.tag == "Player" && other.GetComponent<Player>().isHiding == true) {
         }
         else
            bee.goal = other.gameObject.transform.position;
      }
   }
   private void OnTriggerExit(Collider other)
   {
      if (other.tag == "Player" || (other.tag == "Enemy" && ignoreenemylayer == false))
      {
         if (other.tag == "Player" && other.GetComponent<Player>().isHiding == true)
         {
         }
         else
            bee.goal = transform.position;
      }
   }
}
