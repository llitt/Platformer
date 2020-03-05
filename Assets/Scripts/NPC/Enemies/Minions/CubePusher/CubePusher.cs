using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePusher : MonoBehaviour
{
    private Vector3 target;
    private float speed = 18;
    private Rigidbody myRigidBody;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
        target = startPos;
        myRigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.z < target.z)
        {
            //Debug.Log("moving left");
            myRigidBody.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (gameObject.transform.position.z > target.z)
        {
            //Debug.Log("moving right");
            myRigidBody.AddForce(-Vector3.forward * speed * Time.deltaTime, ForceMode.VelocityChange);
        }
    }

    public void setTarget(Vector3 goTo)
    {
        target = goTo;
    }

    public void resetPosition()
    {
        target = startPos;
        //Debug.Log("resetting cube pusher's position");
    }
}
