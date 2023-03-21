using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peredvijenie_slime : MonoBehaviour
{
	float speed = 2f;
    bool moveingRight = true;
    public float pos1;
    public float pos2;

    void Update()
    {
        if (transform.position.x > pos1)
        {
            moveingRight = false;
        }
        else if (transform.position.x < pos2)
        {
            moveingRight = true;
        }
        if (moveingRight)
        {
           transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
           gameObject.transform.localScale = new Vector3(1,1,1);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed* Time.deltaTime, transform.position.y);
            gameObject.transform.localScale = new Vector3(-1,1,1);
        }
    }
}


