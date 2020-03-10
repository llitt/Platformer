using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingPyramid : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject firstBase;
    public GameObject secondBase;
    public GameObject thirdBase;
    public GameObject forthBase;
    public GameObject fifthBase;
    public GameObject sixthBase;
    public GameObject seventhBase;
    public GameObject lastBase;
    public GameObject player;
    private bool triggered = false;
    public GameObject tempCamera;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.tag == "Movable_Object" && triggered == false)
        {
            StartCoroutine(startAnim());
            triggered = true;
        }
    }


    IEnumerator startAnim()
    {
        Vector3 currCameraPosition = tempCamera.transform.position;
        tempCamera.transform.position = currCameraPosition + new Vector3(100f, 0, 100.3f);
        float currSceneHeight = tempCamera.GetComponent<WidthMatch>().sceneheight;
        tempCamera.GetComponent<WidthMatch>().sceneheight = 220;
        player.GetComponent<Rigidbody>().isKinematic = true;

        
        yield return new WaitForSeconds(1);
        //yield on a new YieldInstruction that waits for 5 seconds.
        firstBase.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(0.5f);
        secondBase.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(0.5f);
        thirdBase.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(0.5f);
        forthBase.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(0.5f);
        fifthBase.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(0.5f);
        sixthBase.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(0.5f);
        seventhBase.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(0.5f);
        lastBase.GetComponent<Animation>().Play();

        yield return new WaitForSeconds(2);

        tempCamera.transform.position = currCameraPosition;
        tempCamera.GetComponent<WidthMatch>().sceneheight = 70;
        player.GetComponent<Rigidbody>().isKinematic = false;
    }
}
