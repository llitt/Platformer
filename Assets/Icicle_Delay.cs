using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icicle_Delay : MonoBehaviour
{
   private float timebeforefall,timer;
    // Start is called before the first frame update
    void Start()
    {
      timebeforefall = Random.Range(0f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
      timer += Time.deltaTime;
    }
   private void FixedUpdate()
   {
      if (timer<timebeforefall)
         GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
   }
}
