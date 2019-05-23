using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Player : MonoBehaviour
{



    bool collided;
    bool canMove;
    //bool isMoving;
    bool isJumping;
    bool isOnGround;
    bool jUp, jDown;


    float initY = -1.9f;
    float y = -1.9f;
    float finalY = 1.4f;

    public float speed = 400;



    // Start is called before the first frame update
    void Start()
    {
        initialize();

    }

    void initialize()
    {
        canMove = true;
        collided = false;
        isOnGround = false;
        isJumping = false;
        jUp = false;
        jDown = false;
    }

    public void setOnGround(bool value)
    {
        isOnGround = value;
        Debug.Log(isOnGround);
    }

    public bool OnGround()
    {
        return isOnGround;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            if (Input.GetKeyDown("space"))
            {

                OnJumpTap();

            }
        }




    }


    public void OnJumpTap()
    {
        if (isOnGround)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, speed));
            gameObject.GetComponent<Animator>().SetTrigger("jump");
            // AudioManager.instance.Play("PlayerJump");
            FindObjectOfType<AudioManager>().Play("PlayerJump");
        }
    }


    public bool hasCollided()
    {
        return collided;
    }

    public void stopPlayer()
    {
        canMove = false;
        gameObject.GetComponent<Animator>().SetBool("stopMovement",true);
    }
}




