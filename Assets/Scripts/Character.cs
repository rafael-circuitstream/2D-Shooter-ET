using UnityEngine;

public class Character : MonoBehaviour
{
    public float moveSpeed;
    public bool isDead;
    
    public Rigidbody2D rigidbodyModule;
    public Health healthModule;

    void Start()
    {
        healthModule = new Health(100);



        healthModule.IncreaseHealth(5.5f);
        Debug.Log( healthModule.GetHealthPoints() );
        healthModule.DecreaseHealth(25.2f);
        Debug.Log( healthModule.GetHealthPoints() );
    }


    public void Move()
    {

    }

    public void Dash()
    {

    }

    public void Attack()
    {

    }
}
