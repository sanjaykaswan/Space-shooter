using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform player;
    protected Joystick joystick;
    protected JoyButton joyButton;
    protected bool shoot;
    public static float speed = 8f;
    public GameObject bulletprefab;
    void Start(){
        joystick = FindObjectOfType<Joystick>();
        joyButton = FindObjectOfType<JoyButton>();
        PlayerPrefs.SetInt("currentScore", 0);
    }
    void Update(){
        var rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(joystick.Horizontal * speed,
                                         joystick.Vertical*speed);
        if (!shoot && JoyButton.pressed)
        {
            shoot = true;
            shootBullet();
        }
        if (shoot && !JoyButton.pressed)
        {
            shoot = false;
        }
    }

    public void shootBullet(){
        GameObject b = Instantiate(bulletprefab) as GameObject;
        b.transform.position = player.transform.position;
    }
}
