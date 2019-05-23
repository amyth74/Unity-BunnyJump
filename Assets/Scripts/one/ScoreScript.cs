using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    int scoreValue = 0;
    public TextMeshProUGUI  score;
    public TextMeshProUGUI finalscore;
    
    public TextMeshProUGUI bstScore;
    


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void UpdateScore(int incrementValue)
    {
        scoreValue = scoreValue + incrementValue;
        score.text = " " + scoreValue;
        
    }

    public void DisplayScore()
    {
        int bstSc=PlayerPrefs.GetInt("bScore",0);

        finalscore.text = "Score: " + scoreValue;
        bstScore.text = "Best: " +bstSc; 
    }
    public int getCurrentScore() {
        return scoreValue;
        
    }

}
