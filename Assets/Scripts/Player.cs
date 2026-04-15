using UnityEngine;

public class Player : Character, IDash
{
    [SerializeField] private Vector2 mousePosition;
    [SerializeField] private Transform weaponTip;
    //[SerializeField] private Projectile projectilePrefab;

    [SerializeField] private Weapon currentWeapon;

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

        if(Input.GetMouseButtonDown(0))
        {
            Attack();
        }

    }

    public override void Attack()
    {
        base.Attack();

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
