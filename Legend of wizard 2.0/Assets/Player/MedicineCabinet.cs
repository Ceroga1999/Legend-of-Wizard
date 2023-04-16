using UnityEngine;

public class MedicineCabinet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.TryGetComponent(out PlayerHealth player))
        {
            player.TakeCure(1);
        }
    }
}
