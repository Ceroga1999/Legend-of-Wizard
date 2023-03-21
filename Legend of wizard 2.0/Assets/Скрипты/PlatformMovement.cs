using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private Transform _upPosition, _downPosition;

    void Update()
    {
        if (transform.position.y > _upPosition.position.y)
        {
            transform.position = Vector2.MoveTowards(transform.position, _downPosition.position, speed * Time.deltaTime);
        }
        else if (transform.position.y < _downPosition.position.y)
        {
            transform.position = Vector2.MoveTowards(transform.position, _upPosition.position, speed * Time.deltaTime);
        }
    }
}
