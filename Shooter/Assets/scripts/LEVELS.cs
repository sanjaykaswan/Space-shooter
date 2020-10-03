using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LEVELS : MonoBehaviour
{
    // Start is called before the first frame update
    // public static float speedOfEnemy;
    // public static float speedOfPlayer;
    // Update is called once per frame
    void Update(){
        // speedOfEnemy = enemyComing.speed;
        // speedOfPlayer = PlayerMove.speed;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Options");
        }
    }
    public void easy(){
        enemyComing.speed = 4f;
        PlayerMove.speed = 8f;
        SceneManager.LoadScene("Mainmenu");
    }
    public void normal(){
        enemyComing.speed = 8f;
        PlayerMove.speed= 10f;
        Repeatenemy.respawnTime = .8f;
        SceneManager.LoadScene("Mainmenu");
    }
    public void hard(){
        enemyComing.speed = 12f;
        PlayerMove.speed = 12f;
        Repeatenemy.respawnTime = .5f;
        SceneManager.LoadScene("Mainmenu");
    }
}
