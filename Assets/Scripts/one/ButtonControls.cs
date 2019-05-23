using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonControls : MonoBehaviour
{
    int x = 0;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = x + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayClick() {
        SceneManager.LoadScene("try_2");
    }
}
