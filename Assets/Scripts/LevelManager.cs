using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
   public static LevelManager LM;
   public int timestage = 1;
   public Vector3 respawnpoint;
    // Start is called before the first frame update
    void Start()
    {
      LM = this;
      Physics.IgnoreLayerCollision(8, 9);
      Physics.IgnoreLayerCollision(8, 10);
   }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape)) {
         if (Cursor.lockState == CursorLockMode.Locked)
         {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
         }
         else {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
         }
      }
    }
}
