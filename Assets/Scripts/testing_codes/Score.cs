using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int finScore = 0;
    public TextMeshProUGUI  finalscore;
    // Start is called before the first frame update
    void Start()
    {
        finalscore = GetComponent<TextMeshProUGUI> () ;
    }

    // Update is called once per frame
    void Update()
    {
        finalscore.text = "Score: " + finScore;
    }
}
