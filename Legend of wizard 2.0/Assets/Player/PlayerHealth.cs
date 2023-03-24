using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health;
    private float _timeBetweenAttack = 0.9f;

    private HealthBar _healthBar;

    private void Start() => _healthBar = GetComponent<HealthBar>();

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            _timeBetweenAttack -= Time.deltaTime;
            if (_timeBetweenAttack <= 0)
            {
                TakeDamage();
                _timeBetweenAttack = 0.9f;
            }
        }
    }

    private void TakeDamage()
    {
        _health--;
        _healthBar.OnDamage();
        if (_health <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
