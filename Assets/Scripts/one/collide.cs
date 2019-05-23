using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class collide : MonoBehaviour
{
    public GameObject overScreen;
    bool coll;

    ScoreScript scoreManager;
    Player player;


    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreScript>();
        player = GameObject.Find("player").GetComponent<Player>();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            coll = true;
            OnGameOver(collision);
        }
        else if (collision.gameObject.tag == "ground")
        {
            player.setOnGround(true);
        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            player.setOnGround(false);
        }
    }


    void OnGameOver(Collision2D collision)
    {

        collision.gameObject.GetComponent<Enemy>().stop();
        // AudioManager.instance.Stop("Theme");
        FindObjectOfType<AudioManager>().Stop("Theme");
        int finalScore = scoreManager.getCurrentScore();
        int bestScore = PlayerPrefs.GetInt("bScore", 0);
        if (finalScore > bestScore)
        {
            bestScore = finalScore;
            PlayerPrefs.SetInt("bScore", bestScore);
        }
        overScreen.SetActive(true);
        scoreManager.DisplayScore();



    }

    public bool isCollided()
    {
        return coll;
    }
}
