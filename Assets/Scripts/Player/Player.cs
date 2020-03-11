using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public GameObject selectWheel,interactCheck;
   public Animator anim;
   public float celrationSpeed = .3f;
   public bool grounded=true,isHiding=false,entryexitmode=false;
   private float speed = 10.0f,heighttoCenter=1.7f;
   public static Player player;
   private float jumpspeed = 12f;
   private float height; 
   public float jumptimer;
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
      
      if (LevelManager.LM.timestage != 3) {
         isHiding = false;
      }
      jumptimer += Time.deltaTime;

      float horiz = Input.GetAxis("Horizontal");
      float vert = Input.GetAxisRaw("Vertical");
      if (entryexitmode == true) {
         horiz = 1;
         vert = 0;
      }
      anim.SetFloat("moving", horiz);
      anim.SetFloat("vertvel", rb.velocity.y);
      if (entryexitmode == false)
      {
         if (Input.GetKeyDown(KeyCode.Escape))
         {
            if (Time.timeScale != 1)
            {
               Time.timeScale = 1;
            }
            else
               Time.timeScale = 0f;
         }
         if (Input.GetButton("Submit"))
         {
            interactCheck.transform.position = transform.position + anim.gameObject.transform.right * 2;
            interactCheck.SetActive(true);
         }
         else if (Input.GetButtonUp("Submit"))
         {
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
      }
      float yspeed;
      if (vert> 0 && jumptimer < .5f)
      {
         grounded = false;
         yspeed = jumpspeed;
      }
      else {
         yspeed = rb.velocity.y;
      }
      if (grounded == false)
      {
         celrationSpeed = .3f;
         jumptimer += Time.deltaTime;
      }
      else if (grounded == true) {
         jumptimer = 0;
      }
      anim.SetFloat("grounddist", grounded?0:2);
      float zspeed = Mathf.Lerp(rb.velocity.z, horiz * speed, celrationSpeed);
         rb.velocity=new Vector3(0,yspeed, zspeed);
      float rbz = Mathf.Clamp(rb.velocity.z, -speed, speed);
   }
   private void OnCollisionStay(Collision collision)
   {
         ContactPoint[] contacts = collision.contacts;
      foreach (ContactPoint cp in contacts)
      {
         if (Vector3.Angle(transform.up, cp.normal) < 75)
         {
            grounded = true;
         }
         Debug.Log(Vector3.Angle(transform.up, cp.normal));
      }
   }
   public void player_DIE() {
      transform.position = LevelManager.LM.respawnpoint;
   }
}
