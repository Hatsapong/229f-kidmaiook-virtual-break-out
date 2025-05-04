using UnityEngine;

private PhysicsMaterial2D originalMaterial;
public PhysicsMaterial2D frozenMaterial;  // Create one with Bounciness = 0

public void Freeze(float duration)
{
    isFrozen = true;
    freezeTimer = duration;

    rb.velocity = Vector2.zero;
    rb.bodyType = RigidbodyType2D.Kinematic;

    // Swap to non-bouncy material
    if (rb.sharedMaterial != null)
    {
        originalMaterial = rb.sharedMaterial;
        rb.sharedMaterial = frozenMaterial;
    }

    if (spriteRenderer != null)
        spriteRenderer.color = Color.cyan;
}

private void Unfreeze()
{
    isFrozen = false;
    rb.bodyType = RigidbodyType2D.Dynamic;

    // Restore original bouncy material
    if (originalMaterial != null)
        rb.sharedMaterial = originalMaterial;

    if (spriteRenderer != null)
        spriteRenderer.color = originalColor;
}
