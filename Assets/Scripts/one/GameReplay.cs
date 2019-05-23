using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameReplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onPlayClick()
    {
        SceneManager.LoadScene("try_2");
    }
     public void onExitClick()
    {
        SceneManager.LoadScene("try_1");
    }
}
