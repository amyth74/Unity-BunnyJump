using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartScreen : MonoBehaviour
{

    public TextMeshProUGUI bestScore;

    public int bScore;
    
    // Start is called before the first frame update
    void Start()
    {
        
        bScore = PlayerPrefs.GetInt("bScore", 0);
        bestScore.text = "" + bScore + "";
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public int currentBest()
    {
        return bScore;
    }
    public void onPlayClick()
    {
        SceneManager.LoadScene("try_2");
        
    }
}
