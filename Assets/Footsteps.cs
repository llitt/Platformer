using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public Player chara;
    public AudioClip[] clips;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chara.grounded && (Input.GetAxis("Horizontal") != 0) && gameObject.GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().clip = clips[Random.Range(0, clips.Length)];
            GetComponent<AudioSource>().Play();
        }
    }
}
