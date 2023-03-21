using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upravlenie : MonoBehaviour
{
    public float speed;
    Rigidbody2D body;
    bool isJump;
    public Animator animator;
    Vector3 size;
    float axis;
    public GameObject spawn1;
    Vector3 ShootDirection;
    GameObject bullet;
    void Start()

    {
        body = GetComponent<Rigidbody2D>();
        isJump = false;
        size = gameObject.transform.localScale;
    }

    void Update()
    {
        axis = Input.GetAxis("Horizontal");


        if(Input.GetButton("Horizontal")) {
            body.velocity = new Vector2(speed * axis, body.velocity.y);
            animator.SetFloat("Speed", 1f);
        }
        else {
            animator.SetFloat("Speed", 0f);
        }

        if(axis > 0) {
            gameObject.transform.localScale = new Vector3(1,1,1);
        }
        if(axis < 0) {
            gameObject.transform.localScale = new Vector3(-1,1,1);
        }
        if(Input.GetButtonDown("Jump") && isJump == false) {
            body.AddForce(transform.up * 5, ForceMode2D.Impulse);
            isJump = true;
            animator.SetBool("isJumping", isJump);

        }

        if (Input.GetButtonDown("Fire1"))
        {
            ShootDirection = new Vector3(Input.mousePosition.x-960f, Input.mousePosition.y-540f, 0);
            ShootDirection = ShootDirection - gameObject.transform.position;
            bullet = Instantiate(spawn1, gameObject.transform.position, gameObject.transform.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = ShootDirection/60; 
         }
    }
    private void OnCollisionEnter2D(Collision2D collision) {

            if(collision.gameObject.tag == "Ground") {
                isJump = false;
                animator.SetBool("isJumping", isJump);
            }
        }
}
