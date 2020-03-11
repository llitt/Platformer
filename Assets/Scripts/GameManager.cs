using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject storyScreen;
    public GameObject controlScreen;
    public GameObject snow;
    public GameObject excludeBackground;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
        snow.GetComponent<AudioSource>().Stop();
      Time.timeScale = .001f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame() {
        titleScreen.gameObject.SetActive(false);
        GetComponent<AudioSource>().Stop();
        snow.GetComponent<AudioSource>().Play();
        Time.timeScale = 1f;
   }

    public void openStory() {
        storyScreen.gameObject.SetActive(true);
        excludeBackground.gameObject.SetActive(false);
    }

    public void openControl() {
        controlScreen.gameObject.SetActive(true);
        excludeBackground.gameObject.SetActive(false);
    }

    public void returnToTitle() {
        controlScreen.gameObject.SetActive(false);
        storyScreen.gameObject.SetActive(false);
        excludeBackground.gameObject.SetActive(true);
    }

    public void disableCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
