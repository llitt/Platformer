using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidBodyTest : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public GameObject player;
    public float speed;
    public bool riding = false;
    public Transform targetA, targetB;
    Vector3 direction;
    Transform destination;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Moves the GameObject using it's transform.
        rb.isKinematic = true;
        SetDestination(targetB);
        float rDistance = Vector3.Distance(transform.position, destination.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos(){
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(targetA.position, transform.localScale);

        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(targetB.position, transform.localScale);
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
        float rDistance = Vector3.Distance(transform.position, destination.position);
        if(rDistance <= 0.1){
            SetDestination(destination == targetA ? targetB : targetA);
        }
        // Moves the GameObject to the left of the origin.
        // float weight = Mathf.Cos (Time.time*speed)*0.5f+0.5f;
        // Vector3 newPosition = targetA.position *weight + targetB.position*(1-weight);
        //     Vector3 changeRate = -this.transform.position + newPosition;
        //     this.transform.position = newPosition;
           
            // Following code for moving the player
            if(riding){
                player.transform.position += new Vector3(0, 0, 0);    
            }
    }
    
    void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject == player)
        {
            print("Player is riding the platform!");
            riding = true;
        }
    }
   
    void OnTriggerExit(Collider hit)
    {
        if(hit.gameObject == player)
        {
            print("Player is off the paltform =/");
            riding = false;
        }
    }

    void SetDestination(Transform dest){
        destination = dest;
        direction = (destination.position - transform.position).normalized;
    }
}
