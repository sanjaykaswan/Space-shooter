using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{

    public float  speed = 50f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public GameObject Explosion;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > screenBounds.x)
        {
            Destroy(this.gameObject);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Enemy")
        {
            GameObject e = Instantiate(Explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            PlayerPrefs.SetInt("currentScore", PlayerPrefs.GetInt("currentScore") + 1 );
            Debug.Log(PlayerPrefs.GetInt("currentScore"));
            if (PlayerPrefs.GetInt("currentScore") > PlayerPrefs.GetInt("highscore"))
            {
                PlayerPrefs.SetInt("highscore",PlayerPrefs.GetInt("currentScore"));
            }
        }
    }
}
