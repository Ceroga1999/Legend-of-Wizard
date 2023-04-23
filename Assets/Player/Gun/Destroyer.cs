using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private float timeDie;
    [SerializeField] private int m_VanishingTime;

    private void Start()
    {
        InvokeRepeating("Annihilator", timeDie, m_VanishingTime);
    }
    private void Annihilator() => Destroy(gameObject);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            Destroy(enemy.gameObject);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
