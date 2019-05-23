using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_enemy : MonoBehaviour
{
    float initX = 9.5f;
    float finalX = -9.5f;
    float X;

    bool canMove;
    float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        initilize();
    }
    void initilize()
    {
        canMove = true;
        X = initX;
        speed = 0.03f;
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove && transform.localPosition.x >= finalX)
        {
            X = transform.localPosition.x - speed;
            gameObject.transform.localPosition = new Vector2(X, -2.5f);
        }
        else if(canMove && transform.localPosition.x < finalX)
        {
            random();
        }
    }

    void random()
    {
        speed=Random.Range(0.06f, 0.1f);
        Debug.Log(speed);
        gameObject.transform.localPosition = new Vector2(initX, -2.5f);
    }
    public void stop()
    {
        canMove = false;
    }
}
