using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingHead : MonoBehaviour
{
   public GameObject plant;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      GetComponent<LineRenderer>().SetPosition(1, plant.transform.position); 
    }
}
