using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeatenemy : MonoBehaviour
{
    public GameObject enemy2prefabe;
    public static float respawnTime = 1.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,Camera.main.transform.position.z));
        StartCoroutine(enemyWave());
    }
    private void spawnEnemy(){
        GameObject a = Instantiate(enemy2prefabe) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y - 3f, screenBounds.y -1f));
    }
    // Update is called once per frame
    IEnumerator enemyWave(){
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
