using UnityEngine;

public class Disappear : MonoBehaviour
{
    [SerializeField] private float timeDie;
    [SerializeField] private int Ischeznovenie;

    private void Start()
    {
        InvokeRepeating("Annihilator", timeDie, Ischeznovenie);
    }
    private void Annihilator() => Destroy(gameObject);
}