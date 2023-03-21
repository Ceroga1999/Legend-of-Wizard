using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        _health--;

        if (_health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
