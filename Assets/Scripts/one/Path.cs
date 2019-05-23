using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    Enemy obstacle;
    public float speed = 1.5f;
    public GameObject refernceGround;


    Vector3 cameraPos;
    float ScreenX;
    float ScreenY;
    // Start is called before the first frame update
    void Start()
    {
        cameraPos = Camera.main.transform.position;
        ScreenX = Vector2.Distance (Camera.main.ScreenToWorldPoint(new Vector2(0,0)),Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0))) * 0.5f;
        ScreenY = Vector2.Distance (Camera.main.ScreenToWorldPoint(new Vector2(0,0)),Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height))) * 0.5f;
        obstacle = GameObject.Find("obstacle").GetComponent<Enemy>();

    }

    // Update is called once per frame
    void Update()
    {
        if(obstacle.canMove)
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }
        
        if(transform.localPosition.x < -(ScreenX + gameObject.GetComponent<SpriteRenderer>().bounds.size.x/2)) 
        {
            reset();
            // Debug.Log("" + gameObject.GetComponent<SpriteRenderer>().bounds.size.x);
        }
    }
    void reset()
    {
        transform.localPosition = new Vector3(refernceGround.transform.localPosition.x + refernceGround.gameObject.GetComponent<SpriteRenderer>().bounds.size.x -0.1f , transform.localPosition.y, 0);
        // transform.localPosition = new Vector3(ScreenX + 2, transform.localPosition.y, 0);
    }
}
