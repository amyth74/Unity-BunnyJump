using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float speed = 0.01f;

    Vector3 cameraPos;
    float ScreenX;
    float screenY;
    Enemy obstacle;

    // Start is called before the first frame update
    void Start()
    {
        cameraPos = Camera.main.transform.position;
        ScreenX = Vector2.Distance (Camera.main.ScreenToWorldPoint(new Vector2(0,0)),Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0))) * 0.5f;
        screenY = Vector2.Distance (Camera.main.ScreenToWorldPoint(new Vector2(0,0)),Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height))) * 0.5f;
        obstacle = GameObject.Find("obstacle").GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if(obstacle.canMove)
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }
        

        if(transform.localPosition.x < -(ScreenX + gameObject.GetComponent<SpriteRenderer>().size.x/2)) {
            reset();
        }
    }
    void reset()
    {
        transform.localPosition = new Vector3(ScreenX + 2, transform.localPosition.y, 0);
    }
}
