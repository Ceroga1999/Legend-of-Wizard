using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Animator animator;
    [SerializeField] private Transform _bulletSpawnPoint;

    private Rigidbody2D _rigitBody;
    private bool isJump;
    private float _moveInput;

    private void Start()
    {
        _rigitBody = GetComponent<Rigidbody2D>();
        isJump = false;
    }

    private void Update()
    {
        _moveInput = Input.GetAxis("Horizontal");

        if (Input.GetButton("Horizontal"))
        {
            Flip();
            _rigitBody.velocity = new Vector2(_speed * _moveInput, _rigitBody.velocity.y);
            animator.SetFloat("Speed", 1f);
        }
        else { animator.SetFloat("Speed", 0f); }

        if (Input.GetButtonDown("Jump") && isJump == false)
        {
            _rigitBody.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
            isJump = true;
            animator.SetBool("isJumping", isJump);
        }
    }

    private void Flip()
    {
        if (_moveInput > 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            _bulletSpawnPoint.localEulerAngles = new Vector3(0, 0, 0);
        }
        if (_moveInput < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
            _bulletSpawnPoint.localEulerAngles = new Vector3(0, 0, -180);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJump = false;
            animator.SetBool("isJumping", isJump);
        }
    }
}
