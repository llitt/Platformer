using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    Vector3 basepose=new Vector3(3.511022f, 5.901861f, 8.690006f);
    // Start is called before the first frame update
    void Start()
    {
      basepose = transform.localPosition;
    }
   
   private void OnEnable()
   {
      transform.localPosition = basepose;
   }
   // Update is called once per frame
   void Update()
   {
      
      transform.position = transform.position + new Vector3(0, Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"));
   }
}
