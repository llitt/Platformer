using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHandler : MonoBehaviour
{
   // Start is called before the first frame update
   public static MusicHandler MH;
   public AudioClip[] musacs;
   public float[] musaclevel;
   public int musicid = 0, lastmusacid = -1;

   void Start()
    {
      DontDestroyOnLoad(this);
      if (MH == null)
      {
         MH = this;
      }
      else
         Destroy(gameObject);
      musicid = 0;
    }

    // Update is called once per frame
    void Update()
    {
      if (musicid != lastmusacid) {
         GetComponent<AudioSource>().clip = musacs[musicid];
         GetComponent<AudioSource>().volume = musaclevel[musicid];
         GetComponent<AudioSource>().Play();
         lastmusacid = musicid;
      }
    }
}
