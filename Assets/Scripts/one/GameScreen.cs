using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreen : MonoBehaviour
{

    public moveBush[] bushes;

    int timer = 60;
    int variable;
    Enemy obstacle;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(createDelay());
        obstacle = GameObject.Find("obstacle").GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        variable = Random.Range(1, 5);
    }

    IEnumerator createDelay()
    {
        do
        {
            yield return new WaitForSeconds(5);
            if (variable % 2 == 0)
            {
                bushes[0].moveGrass = true;
            }
            else
            {
                bushes[1].moveTree = true;
            }


        } while (obstacle.canMove);

    }

    


}
