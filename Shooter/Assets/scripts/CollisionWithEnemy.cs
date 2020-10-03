using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithEnemy : MonoBehaviour
{
    public  static bool collided = false;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy")
        {
            collided = true;
        }
    }
}