using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _damage;
    private float _timeBetweenAttack;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerHealth player))
        {
            _timeBetweenAttack -= Time.deltaTime;
            if (_timeBetweenAttack <= 0)
            {
                player.TakeDamage();
                _timeBetweenAttack = 1;
            }
        }
    }
}