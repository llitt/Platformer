using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WidthMatch : MonoBehaviour
{
   public float sceneheight = 10;

   Camera _camera;
   void Start()
   {
      _camera = GetComponent<Camera>();
   }

   // Adjust the camera's height so the desired scene width fits in view
   // even if the screen/window size changes dynamically.
   void Update()
   {
      float unitsPerPixel = sceneheight / Screen.width;

      float desiredHalfWidth = 0.5f * unitsPerPixel * Screen.width+(0.5f * unitsPerPixel * Screen.width)*.2f;

      _camera.orthographicSize = desiredHalfWidth;
   }
}
