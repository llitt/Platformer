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
        if (chara.grounded && (Input.GetAxis("Horizontal") != 0) && gameObject.GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().clip = snowClips[Random.Range(0, snowClips.Length)];
            GetComponent<AudioSource>().Play();
        }
    }
}
