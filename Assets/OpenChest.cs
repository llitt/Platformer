using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject chest;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
   {
      if (collision.gameObject.tag == "Player") {
         chest.SetActive(false);
         gameObject.SetActive(false);
      }
   }
}
