using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller theBS;

    public GameObject GoodHit;

    public GameObject PerfectHit;

    public static GameManager instance;



    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        Invoke("Next", 20);
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        }
    }
    public void Next()
    {
        SceneManager.LoadScene(7);
    }
    public void NoteHit()
    {
        Debug.Log("Hit");
        for (int i = 0; i <= 30; i = i +1)
        {
            if (i > 3)
            {
                Instantiate(GoodHit, transform.position, GoodHit.transform.rotation);
            } else
            {
                Instantiate(PerfectHit, transform.position, PerfectHit.transform.rotation);
            }
        }
            
    }
    public void NoteMiss()
    {
        Debug.Log("Miss");
    }

}


