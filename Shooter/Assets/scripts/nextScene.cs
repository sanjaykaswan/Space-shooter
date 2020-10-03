using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    private int frames = 0;
    void Update()
    {
        if (frames > 48)
        {
            SceneManager.LoadScene("Mainmenu");
        }
        else
        {
            frames += 1;
        }
    }
}
