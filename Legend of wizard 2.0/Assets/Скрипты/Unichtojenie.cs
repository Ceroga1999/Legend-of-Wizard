using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unichtojenie : MonoBehaviour
{
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {

            if(collision.gameObject.tag == "Slime") {
            	Destroy(collision.gameObject);
            	Destroy(gameObject);
            }
            if(collision.gameObject.tag == "Lian") {
            	Destroy(collision.gameObject);
            	Destroy(gameObject);
            }
            if(collision.gameObject.tag == "Ground") {
            	Destroy(gameObject);
            }
        }
}
