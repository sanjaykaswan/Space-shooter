using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public bool IsMuted;
    public void Start(){
        IsMuted = false;
    }
    public void Music(){
        IsMuted = !IsMuted;
        AudioListener.pause = IsMuted;
    }
    public void Level(){
        SceneManager.LoadScene("levels");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Mainmenu");
        }
    }
}
