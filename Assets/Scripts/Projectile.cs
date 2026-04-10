using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbodyModule;
    [SerializeField] private float projectileSpeed;

    void Start()
    {
        rigidbodyModule.linearVelocity = transform.up * projectileSpeed;
        Destroy(gameObject, 6);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.rigidbody)
        {
            
            if(collision.rigidbody.CompareTag("Enemy"))
            {
                collision.rigidbody.GetComponent<Enemy>().healthModule.DecreaseHealth(50);
            }

        }


        Destroy(gameObject);
    }
}
