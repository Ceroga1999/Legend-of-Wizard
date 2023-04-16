using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health;
    private HealthBar _healthBar;

    private void Start() => _healthBar = FindObjectOfType<HealthBar>().GetComponent<HealthBar>();

    public void TakeDamage(int damage)
    {
        _health -= damage;
        _healthBar.OnDamage(damage, _health);
        if (_health <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void TakeCure(int count)
    {
        if (_health == 5)
        {
            return;
        }
        _health += count;
        _healthBar.OnHealth(count, _health);
    }
}
