using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionArea : MonoBehaviour
{
    public CubePusher cPusher;
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
        if (other.tag == "Player")
        {
            cPusher.setTarget(other.transform.position);
            //Debug.Log("target set to " + other.transform.position);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("target left detection area");
        cPusher.resetPosition();
    }
}
