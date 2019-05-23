using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_collide : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            Debug.Log("collision");
            collision.gameObject.GetComponent<Script_enemy>().stop();
        }
        
    }
}
