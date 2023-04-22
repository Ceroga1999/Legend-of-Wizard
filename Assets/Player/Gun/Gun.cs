using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] Bullet _bullet;
    [SerializeField] Transform _spawnPoint;

    private Vector3 _rotation;

    private void Update()
    {
        _rotation.z = Input.GetAxisRaw("Vertical");
        if (Input.GetButton("Vertical"))
        {
            _spawnPoint.eulerAngles = _rotation * 90;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_bullet, _spawnPoint.position, _spawnPoint.rotation);
        }
    }
}