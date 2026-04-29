using UnityEngine;

public class Player : Character, IDash
{
    [SerializeField] private Vector2 mousePosition;

    [SerializeField] private Weapon currentWeapon;
    [SerializeField] private Transform weaponTip;

    //[SerializeField] private Projectile projectilePrefab;
    
    
    private float shootCountdown;


    protected override void Start()
    {
        //currentWeapon = new RangedWeapon(
        //    newFireRate:10,
        //    newDamage:5, 
        //    newProjectile:projectilePrefab,
        //    newTip:weaponTip
        //    );

        base.Start();

        healthModule.OnHealthZero += EndGame;
    }

    private void EndGame()
    {
        FindAnyObjectByType<GameManager>().RegisterHighScore();
        Destroy(gameObject);
    }

    void Update()
    {
        movementDirection.x = Input.GetAxisRaw("Horizontal");
        movementDirection.y = Input.GetAxisRaw("Vertical");

        mousePosition = Camera.main.ScreenToWorldPoint( Input.mousePosition );

        Rotate(mousePosition);

        Move();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Dash();
        }

        if(shootCountdown <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Attack();
            }
        }
        else
        {
            shootCountdown -= Time.deltaTime;
        }


    }

    public override void Attack()
    {
        base.Attack();

        if(currentWeapon is RangedWeapon currentRangedWeapon)
        {
            shootCountdown = currentRangedWeapon.GetFireRate();
        }
        else
        {
            shootCountdown = 1;
        }

        currentWeapon.Use(weaponTip);
    }

    public void Dash()
    {
        rigidbodyModule.AddForce(movementDirection * moveSpeed * 3f);
    }

    public void EquipWeapon(Weapon newWeapon)
    {
        currentWeapon = newWeapon;
        
    }

}
