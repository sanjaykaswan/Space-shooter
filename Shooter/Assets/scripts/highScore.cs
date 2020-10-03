using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class highScore : MonoBehaviour
{
    public Text highscoreText;
    // Start is called before the first frame update
    void Start()
    {
        highscoreText.text = "HIGH SCORE:" + PlayerPrefs.GetInt("highscore").ToString();
    }

    // Update is called once per frame
    public void refresh(){
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            highscoreText.text = "HIGH SCORE:" + PlayerPrefs.GetInt("highscore").ToString();
        }
    }
}