using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollidedMenu : MonoBehaviour
{  
    public GameObject CollidedMenuUI;
    public void Start(){
        CollidedMenuUI.SetActive(false);
    }
    private void Update(){
        if (CollisionWithEnemy.collided)
        {
            Debug.Log("update");
            Time.timeScale = 0f;
            CollidedMenuUI.SetActive(true);
            CollisionWithEnemy.collided = false;
        }
    }
    public void Restart(){
        
        Time.timeScale = 1f;
        CollidedMenuUI.SetActive(false);
        SceneManager.LoadScene("game");
        Debug.Log("wooooow");
    }
    public void LoadMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Mainmenu");
    }
    public void QuitGame(){
        Debug.Log("Quitting Game....");
        Application.Quit();
    }
}
