using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health;
    private HealthBar _healthBar;

    private void Start() => _healthBar = GetComponent<HealthBar>();

    public void TakeDamage()
    {
        _health--;
        _healthBar.OnDamage();
        if (_health <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
