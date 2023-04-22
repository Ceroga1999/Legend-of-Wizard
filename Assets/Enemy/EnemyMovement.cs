using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private Transform _leftPosition, _rightPosition;
    bool moving = true;

    void FixedUpdate()
    {
        if (transform.position.y >= 3f)
        {
            moving = false;
        }
        else if (transform.position.y <= -1f)
        {
            moving = true;
        }

        if (moving)
        {
            transform.position = new Vector2(transform.position.y + _speed * Time.deltaTime, transform.position.x);
        }
        else
        {
            transform.position = new Vector2(transform.position.y - _speed * Time.deltaTime, transform.position.x);
        }
    }
}
