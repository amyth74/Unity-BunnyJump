using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    float X;
    float initX = 10.76f;
    float finalX = -9.9f;

    public bool canMove;

    public float randomVar;
    public float speed;

    float duration = 1.0f;
    bool scoreUpdatedOnCurrentTurn;

    Player player;
    ScoreScript scoreManager;


    // Start is called before the first frame update
    void Start()
    {
        initialize();

        player = GameObject.Find("player").GetComponent<Player>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreScript>();

    }

    void initialize()
    {
        canMove = true;
        X = initX;
        speed = 0.08f;

        scoreUpdatedOnCurrentTurn = false;


    }

    public void stop()
    {
        gameObject.GetComponent<Animator>().SetBool("StopMoving", true);
        // AudioManager.instance.Play("Hit");
        FindObjectOfType<AudioManager>().Play("Hit");
        canMove = false;
        player.stopPlayer();

    }

    // Update is called once per frame
    void Update()
    {

        start();


    }
    void start()
    {
        if (canMove)
        {
            if (transform.localPosition.x >= finalX)
            {
                X = transform.localPosition.x - speed;
                transform.localPosition = new Vector2(X, -2.3f);
            }
            else
            {
                Randomize();
            }
        }

        if (!scoreUpdatedOnCurrentTurn && gameObject.transform.localPosition.x < (player.gameObject.transform.localPosition.x - 2))
        {
            scoreUpdatedOnCurrentTurn = true;
            scoreManager.UpdateScore(1);
        }

    }
    public void Randomize()
    {

        speed += 0.005f;
        scoreUpdatedOnCurrentTurn = false;
        //Debug.Log(speed);
        transform.localPosition = new Vector2(initX, -2.3f);
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        gameObject.GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.green, lerp);



    }

}