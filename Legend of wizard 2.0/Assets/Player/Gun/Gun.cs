using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] Bullet _bullet;
    [SerializeField] Transform _spawnPoint;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_bullet, _spawnPoint.position, _spawnPoint.rotation);
        }
    }
}