using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public GameObject selectWheel,interactCheck;
   public Animator anim;
   public float celrationSpeed = .3f;
   public bool grounded=true,isHiding=false;
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

      anim.SetFloat("moving", Input.GetAxis("Horizontal"));
      anim.SetFloat("vertvel", rb.velocity.y);
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
      float yspeed;
      if (Input.GetAxisRaw("Vertical") > 0 && jumptimer < .5f)
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
      RaycastHit rh;
      Physics.Raycast(transform.position, Vector3.down, out rh);
      anim.SetFloat("grounddist", grounded?0:2);
      if (rh.distance > 2) {
         grounded = false;
      }
      float zspeed = Mathf.Lerp(rb.velocity.z, Input.GetAxis("Horizontal") * speed, celrationSpeed);
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
