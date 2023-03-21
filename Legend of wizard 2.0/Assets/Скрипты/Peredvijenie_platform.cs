using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peredvijenie_platform : MonoBehaviour
{
    float speed = 2f;
    float dirX;
    bool moveinUp = true;
    public float position1;
    public float position2;



    // Update is called once per frame
    void Update()
    {
        	if (transform.position.y > position1) {
        		moveinUp = false;

        	}
        	else if (transform.position.y < position2) {
        		moveinUp = true;

        	} 
        	if (moveinUp) {
        		transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        	}
        	else {
        		transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        	}
    }
}
