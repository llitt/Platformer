using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public GameObject selectWheel,interactCheck;
   public Animator anim;
   public bool grounded=true;
   public float speed = 10.0f,heighttoCenter=1.7f;
   public static Player player;
   public int jumpcount = 0;
   public float jumpforce = 10;
   private float height; 
   private float jumptimer;
   private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
      interactCheck = Instantiate(interactCheck, transform.position + anim.gameObject.transform.right * 2, Quaternion.identity);
      interactCheck.SetActive(false);
      Physics.gravity = new Vector3(0, -20f, 0);
      player = this;
      rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      anim.SetFloat("moving", rb.velocity.z);
      anim.SetFloat("vertvel", rb.velocity.y);
      if (Input.GetButton("Submit"))
      {
         interactCheck.transform.position = transform.position + anim.gameObject.transform.right*2;
         interactCheck.SetActive(true);
      }
      else if (Input.GetButtonUp("Submit")) {
         interactCheck.SetActive(false);
      }
      if (Input.GetButtonDown("Fire1"))
      {
         Time.timeScale = .25f;
         selectWheel.SetActive(true);
      }
      else if (Input.GetButtonUp("Fire1"))
      {
         Time.timeScale = 1f;
         selectWheel.SetActive(false);
      }
      if (Input.GetAxisRaw("Vertical") > 0&& jumpcount<10) {
     
         jumpcount++;
         grounded = false;
         rb.AddForce(transform.up*jumpforce, ForceMode.Impulse);
      }
      Debug.Log(Input.GetAxisRaw("Vertical"));
      if (grounded == true && Input.GetAxisRaw("Vertical")<=0) {
         jumpcount = 0;
      }
      RaycastHit Rhit;
      if (Physics.Raycast(transform.position, Vector3.down, out Rhit)) {
         anim.SetFloat("grounddist", Rhit.distance);
         if (Rhit.distance < heighttoCenter) {
            grounded = true;
         }
      }
      float zspeed = Mathf.Lerp(rb.velocity.z, Input.GetAxis("Horizontal") * speed, .3f);
         rb.velocity=new Vector3(0,rb.velocity.y, Input.GetAxis("Horizontal") * speed);
      float rbz = Mathf.Clamp(rb.velocity.z, -speed, speed);
   }
}
