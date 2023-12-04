using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SongLoad : MonoBehaviour
{
    //    public object[] notes = (0,1)
    //    public object[] songInfo = new object[4];
    //    songInfo[0] = "Title";
    //    songInfo[1] = "Artist";
    //    songInfo[2] = AudioSource song;
    //    songInfo[3] = ArrayList notes = new ArrayList();

    // Start is called before the first frame update
    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void GoldenHour()
    {
        SceneManager.LoadScene(6);
    }
}
