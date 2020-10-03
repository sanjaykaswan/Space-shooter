using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectwidth;
    private float objectheight;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.x));
        objectwidth = transform.GetComponent<SpriteRenderer>().bounds.size.x/2;
        objectheight = transform.GetComponent<SpriteRenderer>().bounds.size.y/2;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, (screenBounds.x * -1) + (objectwidth/2), screenBounds.x - (objectwidth/2));
        viewPos.y = Mathf.Clamp(viewPos.y , (screenBounds.y * -1)*2 , screenBounds.y - 1.5f);
        transform.position = viewPos;
    }
}
