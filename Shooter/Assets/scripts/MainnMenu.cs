using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainnMenu : MonoBehaviour
{
    public void QuitGame(){
        Debug.Log("Quitting Game....");
        Application.Quit();
    }
    public void PlayGame(){
        SceneManager.LoadScene("game");
    }
    public void options(){
        SceneManager.LoadScene("Options");
    }
}
