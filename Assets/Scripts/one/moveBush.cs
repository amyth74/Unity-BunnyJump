using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBush : MonoBehaviour
{
    
    Enemy obstacle;
    bool isMoving;
    public bool moveGrass;
    public bool moveTree;

    float X;
    float Z;
    float finalGrassX;
    float initGrassX;
    float finalTreeX;
    float initTreeX;
    
    public float speed = 0.01f;

    int x=10;
    // Start is called before the first frame update
    void Start()
    {
       initilize();
       obstacle = GameObject.Find("obstacle").GetComponent<Enemy>();

    }
    void initilize()
    {
        isMoving = true;
        moveGrass = false;
        moveTree = false;
        X = 10.8f;
        Z = 11.67f;
        finalTreeX = -11.5f;
        initTreeX = 11.67f;
        finalGrassX = -10.8f;
        initGrassX = 10.9f;
        // initPosition();
        // initPositionTree();


    }
    

    // Update is called once per frame
    void Update()
    {
        move();
    }
    
    void initPosition()
    {
        gameObject.transform.localPosition = new Vector2(initGrassX, -2.5f);
        isMoving = true;
        // Debug.Log("init ma aayo");
        

    }
    void initPositionTree()
    {
        gameObject.transform.localPosition = new Vector2(initTreeX, -1.4f);
        isMoving = true;
        // Debug.Log("init ma aayo");
        

    }

    void move()
    {
        if(obstacle.canMove)
        {
        if (isMoving && moveGrass)
        {
            if (transform.localPosition.x >= finalGrassX)
            {
                
                transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
            }
            else
            {
                isMoving = false;
                moveGrass = false;
                initPosition();
            }

        }
        else if (isMoving && moveTree)
        {
            if (transform.localPosition.x >= finalTreeX)
            {
                // Debug.Log("grass ko code");
               transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
            }
            else
            {
                isMoving = false;
                moveTree = false;
                initPositionTree();
            }
        }
        } 
    }
    
}
