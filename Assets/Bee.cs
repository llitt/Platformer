using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{
    public Vector3 goal;
   public float speed = .3f,mindistance=.4f,timetowait=2f;
   private float timer = 0f,y;
   public bool keepylevel=false;
   int goaltarget = 0;
      public Transform[] waypoints;
    void Start()
    {
      goal = waypoints[goaltarget].position;
      y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
      
      if (keepylevel)
      {
         goal = new Vector3(goal.x, y, goal.z);
      }
      
      if (Vector3.Distance(transform.position, goal)<mindistance) {
         if (timer >= timetowait)
         {
            goaltarget++;
            if (goaltarget >= waypoints.Length)
            {
                  goaltarget = 0;
            }
            goal = waypoints[goaltarget].position;
            timer = 0;
         }
         timer += Time.deltaTime;
         
      }
      else if (Vector3.Distance(transform.position, goal) < mindistance * 10)
      {
         transform.position = Vector3.Lerp(transform.position, goal, speed*10);
      }
      else
         transform.position = Vector3.Lerp(transform.position, goal, speed);
   }
   private void OnCollisionEnter(Collision collision)
   {
      if (collision.gameObject.tag == "Player") {
         collision.gameObject.GetComponent<Player>().player_DIE();
      }
      if (collision.gameObject.tag == "Enemy")
      {
         Destroy(collision.gameObject);
      }
      goaltarget++;
      if (goaltarget >= waypoints.Length)
      {
         goaltarget = 0;
      }
      goal = waypoints[goaltarget].position;
   }
}
