using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollisionChangeLevel : MonoBehaviour
{
   public int scenetoload = 1;

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
         SceneManager.LoadScene(scenetoload);
      }
   }
}
