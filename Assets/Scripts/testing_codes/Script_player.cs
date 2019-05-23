using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_player : MonoBehaviour
{

    float initY = -2f;
    float finalY = 1.5f;
    float Y;
    bool onGround;

    
    // Start is called before the first frame update
    void Start()
    {
        initialize();
    }
    void initialize()
    {
        
        Y = initY;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,400));
        }
        
        
    }
}
