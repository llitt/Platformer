using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonLionAnt : MonoBehaviour
{
   // Start is called before the first frame update
   public GameObject winscreen;
    public bool key1 = false;
    public bool key2 = false;
    public bool key3 = false;
    public bool key4 = false;
    public GameObject lionAnt;
    public GameObject tempCamera;
    public GameObject boss;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(key1 && key2 && key3 && key4){
            StartCoroutine(summonAnt());
            key1 = false;
        }
    }

    IEnumerator summonAnt() {
        Vector3 currCameraPosition = tempCamera.transform.position;
        tempCamera.transform.position = new Vector3(119.91f, 14.54f, 900f);
        float currSceneHeight = tempCamera.GetComponent<WidthMatch>().sceneheight;
        tempCamera.GetComponent<WidthMatch>().sceneheight = 100;
        GetComponent<Rigidbody>().isKinematic = true;

        yield return new WaitForSeconds(3);
        lionAnt.SetActive(true);
        yield return new WaitForSeconds(2);
        boss.GetComponent<SpriteRenderer>().enabled = false;
        boss.SetActive(false);
        yield return new WaitForSeconds(2);
        lionAnt.SetActive(false);
        tempCamera.transform.position = currCameraPosition;
        tempCamera.GetComponent<WidthMatch>().sceneheight = 40;
        GetComponent<Rigidbody>().isKinematic = false;
      winscreen.SetActive(true);
    }

    void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.name == "key1")
        {
            key1 = true;
            hit.gameObject.SetActive(false);
        }
        if(hit.gameObject.name == "key2")
        {
            key2 = true;
            hit.gameObject.SetActive(false);
        }
        if(hit.gameObject.name == "key3")
        {
            key3 = true;
            hit.gameObject.SetActive(false);
        }
        if(hit.gameObject.name == "key4")
        {
            key4 = true;
            hit.gameObject.SetActive(false);
        }
    }
}
