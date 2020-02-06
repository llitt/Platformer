using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWheel : MonoBehaviour
{
   private float deltatime,lasttime;
   public float rotspeed=5f;
   public Transform mouse;
    // Start is called before the first frame update
    void Start()
    {
      lasttime = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
      deltatime = Time.realtimeSinceStartup - lasttime;
      lasttime = Time.realtimeSinceStartup;
 
      float ymov = Input.GetAxis("Mouse Y");
      //Vector3 offset=new Vector3 (0, ymov, xmov);
      Debug.Log(Input.mousePosition);
      //transform.LookAt(new Vector3(0,Input.mousePosition.y, Input.mousePosition.x));
      transform.LookAt(mouse);
      transform.localRotation.SetEulerRotation(transform.localRotation.eulerAngles.x,0,transform.localRotation.eulerAngles.z);
      
    }
}
