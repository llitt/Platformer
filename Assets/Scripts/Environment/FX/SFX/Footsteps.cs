using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
   public Player chara;
   public AudioClip[] snowClips;
   public AudioClip[] sandClips;
   public AudioClip[] grassClips;
   public AudioClip[] swampClips;
   // Start is called before the first frame update
   void Start()
   {

   }

   // Update is called once per frame
   void Update()
   {
      if (chara.grounded && ((Input.GetAxis("Horizontal") != 0)|chara.entryexitmode==true) && gameObject.GetComponent<AudioSource>().isPlaying == false)
      {
         if (LevelManager.LM.timestage == 2)
         {
            GetComponent<AudioSource>().clip = snowClips[Random.Range(0, snowClips.Length)];
            GetComponent<AudioSource>().Play();
         }
         else if (LevelManager.LM.timestage == 0)
         {
            GetComponent<AudioSource>().clip = grassClips[Random.Range(0, grassClips.Length)];
            GetComponent<AudioSource>().Play();
         }
         else if (LevelManager.LM.timestage == 1)
         {
            GetComponent<AudioSource>().clip = sandClips[Random.Range(0, sandClips.Length)];
            GetComponent<AudioSource>().Play();
         }
         else if (LevelManager.LM.timestage == 3)
         {
            GetComponent<AudioSource>().clip = swampClips[Random.Range(0, swampClips.Length)];
            GetComponent<AudioSource>().Play();
         }
      }
   }
}
