using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private Transform _leftPosition, _rightPosition;

    void Update()
    {
        if (transform.position.x > _rightPosition.position.x)
        {
            transform.position = Vector2.MoveTowards(transform.position, _leftPosition.position, speed * Time.deltaTime);
        }
        else if (transform.position.x < _leftPosition.position.x)
        {
            transform.position = Vector2.MoveTowards(transform.position, _rightPosition.position, speed * Time.deltaTime);
        }
    }
}
