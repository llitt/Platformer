using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skipToEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Player"){
            collision.collider.transform.position = new Vector3(0, 14.54f, 580f);
        }
    }
}
