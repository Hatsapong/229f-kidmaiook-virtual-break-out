using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    // Handle trigger with enemies (trigger collider)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);  // Destroy the enemy
            Destroy(gameObject);           // Destroy the bullet
        }
    }
}
