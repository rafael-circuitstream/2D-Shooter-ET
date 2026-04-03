using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbodyModule;
    [SerializeField] private float projectileSpeed;

    void Start()
    {
        rigidbodyModule.linearVelocity = transform.up * projectileSpeed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
