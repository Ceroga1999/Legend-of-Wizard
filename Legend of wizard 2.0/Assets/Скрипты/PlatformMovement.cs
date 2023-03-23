using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _upPosition, _downPosition;
    bool moving = true;

    void FixedUpdate()
    {
        if (transform.position.y >= _upPosition)
        {
            moving = false;
        }
        else if (transform.position.y <= _downPosition)
        {
            moving = true;
        }

        if (moving)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + _speed * Time.fixedDeltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - _speed * Time.fixedDeltaTime);
        }
    }
}
