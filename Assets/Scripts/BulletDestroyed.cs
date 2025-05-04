using UnityEngine;

public class BulletDestroyed : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject); // Destroy the bullet
        }
    }
}
